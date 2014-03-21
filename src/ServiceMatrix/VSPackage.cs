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
using System.Linq;
using NuPattern;
using NuPattern.Diagnostics;
using NuPattern.Runtime;
using NuPattern.VisualStudio;
using NuPattern.Runtime.Diagnostics;
using ServiceMatrix.Diagramming.Views;
using ServiceMatrix.Diagramming;
using System.ComponentModel.Composition.Hosting;
using DslShell = global::Microsoft.VisualStudio.Modeling.Shell;
using NServiceBusStudio.Automation.Exceptions;
using System.IO;

namespace NServiceBusStudio
{
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [PartCreationPolicy(CreationPolicy.Shared)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [ProvideAutoLoad(UIContextGuids.NoSolution)]
    [Guid(GuidList.guidNServiceBusStudioPkgString)]
    [ProvideToolWindow(typeof(NServiceBusDetailsToolWindow), Window = ToolWindowGuids.TaskList, Style = VsDockStyle.Tabbed, Transient = true)]
    [ProvideToolWindow(typeof(ServiceMatrixDiagramToolWindow), Window = ToolWindowGuids.DocOutline, Style = VsDockStyle.MDI, Transient = true)]
    [ProvideOptionPage(typeof(GeneralOptionsPage), "ServiceMatrix", "General", 0, 0, true)]
    [ProvideService(typeof(IDetailsWindowsManager), ServiceName = "IDetailsWindowManager")]
    [ProvideService(typeof(IDiagramsWindowsManager), ServiceName = "IDiagramsWindowsManager")]
    [ProvideService(typeof(NServiceBusDetailsToolWindow), ServiceName = "NServiceBusDetailsToolWindow")]
    [ProvideService(typeof(ServiceMatrixDiagramToolWindow), ServiceName = "NServiceBusDiagramsToolWindow")]
    [DslShell::ProvideBindingPath]
    public sealed class VSPackage : Package, IDetailsWindowsManager, IDiagramsWindowsManager
    {
        [Import]
        public ITraceOutputWindowManager TraceOutputWindowManager { get; set; }

        protected override void Initialize()
        {
            base.Initialize();

            this.AddServices();
            this.EnsureCreateTraceOutput();
            this.TrackUnhandledExceptions();
        }

        private void TrackUnhandledExceptions()
        {
            // TODO: Select and implement an Exception Reporter Component (Not under GNU License).

            var type = typeof(TraceSourceExtensions);
            var field = type.GetField("ShowExceptionAction", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
            field.SetValue(null, new Action<string, Exception>((s, e) =>
            {
                if (!(e is ElementAlreadyExistsException))
                {
                    System.Windows.MessageBox.Show("An unexpected error ocurred during your last operation. Please, try again or report this issue if it persists (support@particular.net).\r\n\r\nException: " + e.Message, "ServiceMatrix - Unexpected Exception", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                }
            }));
        }

        private void EnsureCreateTraceOutput()
        {
            // Creating Trace Output Window
            var componentModel = this.GetService<SComponentModel, IComponentModel>();
            componentModel.DefaultCompositionService.SatisfyImportsOnce(this);

            Trace.AutoFlush = true;

            var traceManager = Tracer.Manager as TracerManager;
            if (traceManager != null)
            {
                traceManager.SetTracingLevel(StatisticsManager.StatisticsListenerNamespace, SourceLevels.All);
            }

            this.TraceOutputWindowManager.CreateTracePane(new Guid("8678B5A5-9811-4D3E-921D-789E82C690D6"), "ServiceMatrix Logging", new[] { StatisticsManager.StatisticsListenerNamespace });
        }

        private void AddServices()
        {
            var serviceContainer = (IServiceContainer)this;
            serviceContainer.AddService(typeof(IDetailsWindowsManager), this, true);
            serviceContainer.AddService(typeof(IDiagramsWindowsManager), this, true);
        }

        void IDetailsWindowsManager.Show()
        {
            var window = this.EnsureCreateToolWindow<NServiceBusDetailsToolWindow>();
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

        void IDiagramsWindowsManager.Show()
        {
            var window = this.EnsureCreateToolWindow<ServiceMatrixDiagramToolWindow>();
            if (window != null)
            {
                var frame = (IVsWindowFrame)window.Frame;
                frame.Show();
            }
        }

        private void EnableDisableDetailsPanel(bool enable)
        {
            var window = this.EnsureCreateToolWindow<NServiceBusDetailsToolWindow>();
            if (window != null)
            {
                var content = (DetailsPanel)window.Content;
                content.IsEnabled = enable;
            }
        }

        T EnsureCreateToolWindow<T>() where T : class
        {
            var window = this.FindToolWindow(typeof(T), 0, false);
            if (window == null)
            {
                try
                {
                    window = this.CreateToolWindow(typeof(T), 0).As<ToolWindowPane>();
                    var serviceContainer = (IServiceContainer)this;
                    serviceContainer.AddService(typeof(T), window.As<T>(), true);
                }
                catch (Exception ex)
                {
                    var s = ex.Message;
                    throw;
                }
            }

            return window as T;
        }
    }
}
