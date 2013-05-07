﻿using Microsoft.VisualStudio.ComponentModelHost;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using NServiceBusStudio.Automation.CustomSolutionBuilder;
using NServiceBusStudio.Automation.CustomSolutionBuilder.Views;
using NServiceBusStudio.Automation.Infrastructure;
using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.InteropServices;
using NuPattern;
using NuPattern.Runtime;
using NuPattern.VisualStudio;
using NuPattern.Runtime.Diagnostics;

namespace NServiceBusStudio
{
    [ProvideToolWindow(typeof(NServiceBusDetailsToolWindow), Transient = false, MultiInstances = false, Style = VsDockStyle.Tabbed, Window = EnvDTE.Constants.vsWindowKindOutput)]
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [Guid(GuidList.guidNServiceBusStudioPkgString)]
    [PartCreationPolicy(CreationPolicy.Shared)]
    [ProvideService(typeof(IDetailsWindowsManager), ServiceName = "IDetailsWindowManager")]
    [ProvideService(typeof(NServiceBusDetailsToolWindow), ServiceName = "NServiceBusDetailsToolWindow")]
    [ProvideAutoLoad(UIContextGuids.NoSolution)]
    public sealed class VSPackage : NServiceBus.Modeling.EndpointDesign.EndpointDesignPackage, IDetailsWindowsManager
    {
        [Import]
        public ITraceOutputWindowManager TraceOutputWindowManager { get; set; }

        protected override void Initialize()
        {
            base.Initialize();
            this.AddServices();
            this.EnsureCreateToolWindow<NServiceBusDetailsToolWindow>();
            this.EnsureCreateTraceOutput();
        }

        private void EnsureCreateTraceOutput()
        {
            // Creating Trace Output Window
            var componentModel = this.GetService<SComponentModel, IComponentModel>();
            componentModel.DefaultCompositionService.SatisfyImportsOnce(this);

            this.TraceOutputWindowManager.CreateTracePane (new Guid("8678B5A5-9811-4D3E-921D-789E82C690D6"), "NServiceBus Studio Logging", new [] { StatisticsManager.StatisticsListenerNamespace });
            Trace.AutoFlush = true;
        }

        private void AddServices()
        {
            var serviceContainer = (IServiceContainer)this;
            serviceContainer.AddService(typeof(IDetailsWindowsManager), this, true);
        }

        void IDetailsWindowsManager.Show()
        {
            var window = this.FindToolWindow(typeof(NServiceBusDetailsToolWindow), 0, false);
            if (window != null)
            {
                var frame = (IVsWindowFrame)window.Frame;
                frame.Show();
            }
        }

        void IDetailsWindowsManager.Enable()
        {
            EnableDisableDetailsPanel(true);
        }

        void IDetailsWindowsManager.Disable()
        {
            EnableDisableDetailsPanel(false);
        }

        private void EnableDisableDetailsPanel(bool enable)
        {
            var window = this.FindToolWindow(typeof(NServiceBusDetailsToolWindow), 0, false);
            if (window != null)
            {
                var content = (DetailsPanel)window.Content;
                content.IsEnabled = enable;
            }
        }

        void EnsureCreateToolWindow<T>() 
            where T: class
        {
            System.Windows.Threading.Dispatcher.CurrentDispatcher.BeginInvoke(new Action(() =>
                {
                    var window = this.FindToolWindow(typeof(T), 0, false);
                    if (window == null)
                    {
                        try
                        {
                            window = this.CreateToolWindow(typeof(T), 0).As<ToolWindowPane>();

                        }
                        catch (Exception ex)
                        {
                            var s = ex.Message;
                            throw;
                        }
                    }
                    var serviceContainer = (IServiceContainer)this;
                    serviceContainer.AddService(typeof(T), window.As<T>(), true); 
                    var frame = (IVsWindowFrame)window.Frame;
                    //frame.Show();
                }));
        }
    }
}
