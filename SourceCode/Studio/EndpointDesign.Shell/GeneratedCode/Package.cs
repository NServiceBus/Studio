﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using VSShellInterop = global::Microsoft.VisualStudio.Shell.Interop;
using VSShell = global::Microsoft.VisualStudio.Shell;
using DslShell = global::Microsoft.VisualStudio.Modeling.Shell;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslModeling = global::Microsoft.VisualStudio.Modeling;
using VSTextTemplatingHost = global::Microsoft.VisualStudio.TextTemplating.VSHost;
using System;
using System.Diagnostics;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;
	
namespace NServiceBus.Modeling.EndpointDesign
{
	/// <summary>
	/// This class implements the VS package that integrates this DSL into Visual Studio.
	/// </summary>
	[VSShell::DefaultRegistryRoot("Software\\Microsoft\\VisualStudio\\10.0")]
	[VSShell::PackageRegistration(RegisterUsing = VSShell::RegistrationMethod.Assembly, UseManagedResourcesOnly = true)]
	[VSShell::ProvideToolWindow(typeof(EndpointDesignExplorerToolWindow), MultiInstances = false, Style = VSShell::VsDockStyle.Tabbed, Orientation = VSShell::ToolWindowOrientation.Right, Window = "{3AE79031-E1BC-11D0-8F78-00A0C9110057}")]
	[VSShell::ProvideToolWindowVisibility(typeof(EndpointDesignExplorerToolWindow), Constants.EndpointDesignEditorFactoryId)]
	[VSShell::ProvideStaticToolboxGroup("@NServiceBusToolboxTab;NServiceBus.Modeling.EndpointDesign.dll", "NServiceBus.Modeling.EndpointDesign.NServiceBusToolboxTab")]
	[VSShell::ProvideStaticToolboxItem("NServiceBus.Modeling.EndpointDesign.NServiceBusToolboxTab",
					"@SendEndpointToolboxItem;NServiceBus.Modeling.EndpointDesign.dll", 
					"NServiceBus.Modeling.EndpointDesign.SendEndpointToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"", 
					"@SendEndpointToolboxBitmap;NServiceBus.Modeling.EndpointDesign.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("NServiceBus.Modeling.EndpointDesign.NServiceBusToolboxTab",
					"@SendReceiveEndpointToolboxItem;NServiceBus.Modeling.EndpointDesign.dll", 
					"NServiceBus.Modeling.EndpointDesign.SendReceiveEndpointToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"", 
					"@SendReceiveEndpointToolboxBitmap;NServiceBus.Modeling.EndpointDesign.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("NServiceBus.Modeling.EndpointDesign.NServiceBusToolboxTab",
					"@EventToolboxItem;NServiceBus.Modeling.EndpointDesign.dll", 
					"NServiceBus.Modeling.EndpointDesign.EventToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"", 
					"@EventToolboxBitmap;NServiceBus.Modeling.EndpointDesign.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("NServiceBus.Modeling.EndpointDesign.NServiceBusToolboxTab",
					"@CommandToolboxItem;NServiceBus.Modeling.EndpointDesign.dll", 
					"NServiceBus.Modeling.EndpointDesign.CommandToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"", 
					"@CommandToolboxBitmap;NServiceBus.Modeling.EndpointDesign.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("NServiceBus.Modeling.EndpointDesign.NServiceBusToolboxTab",
					"@ProcessToolboxItem;NServiceBus.Modeling.EndpointDesign.dll", 
					"NServiceBus.Modeling.EndpointDesign.ProcessToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"Process", 
					"@ProcessToolboxBitmap;NServiceBus.Modeling.EndpointDesign.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("NServiceBus.Modeling.EndpointDesign.NServiceBusToolboxTab",
					"@EmitToolboxItem;NServiceBus.Modeling.EndpointDesign.dll", 
					"NServiceBus.Modeling.EndpointDesign.EmitToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"Emit", 
					"@EmitToolboxBitmap;NServiceBus.Modeling.EndpointDesign.dll", 
					0xff00ff)]
	[VSShell::ProvideEditorFactory(typeof(EndpointDesignEditorFactory), 103, TrustLevel = VSShellInterop::__VSEDITORTRUSTLEVEL.ETL_AlwaysTrusted)]
	[VSShell::ProvideEditorExtension(typeof(EndpointDesignEditorFactory), "." + Constants.DesignerFileExtension, 50)]
	[DslShell::ProvideRelatedFile("." + Constants.DesignerFileExtension, Constants.DefaultDiagramExtension,
		ProjectSystem = DslShell::ProvideRelatedFileAttribute.CSharpProjectGuid,
		FileOptions = DslShell::RelatedFileType.FileName)]
	[DslShell::ProvideRelatedFile("." + Constants.DesignerFileExtension, Constants.DefaultDiagramExtension,
		ProjectSystem = DslShell::ProvideRelatedFileAttribute.VisualBasicProjectGuid,
		FileOptions = DslShell::RelatedFileType.FileName)]
	[DslShell::RegisterAsDslToolsEditor]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[DslShell::ProvideBindingPath]
	[DslShell::ProvideXmlEditorChooserBlockSxSWithXmlEditor(@"EndpointDesign", typeof(EndpointDesignEditorFactory))]
	public abstract partial class EndpointDesignPackageBase : DslShell::ModelingPackage
	{
		protected global::NServiceBus.Modeling.EndpointDesign.EndpointDesignToolboxHelper toolboxHelper;	
		
		/// <summary>
		/// Initialization method called by the package base class when this package is loaded.
		/// </summary>
		protected override void Initialize()
		{
			base.Initialize();

			// Register the editor factory used to create the DSL editor.
			this.RegisterEditorFactory(new EndpointDesignEditorFactory(this));
			
			// Initialize the toolbox helper
			toolboxHelper = new global::NServiceBus.Modeling.EndpointDesign.EndpointDesignToolboxHelper(this);

			// Create the command set that handles menu commands provided by this package.
			EndpointDesignCommandSet commandSet = new EndpointDesignCommandSet(this);
			commandSet.Initialize();
			
			// Create the command set that handles cut/copy/paste commands provided by this package.
			EndpointDesignClipboardCommandSet clipboardCommandSet = new EndpointDesignClipboardCommandSet(this);
			clipboardCommandSet.Initialize();
			
			// Register the model explorer tool window for this DSL.
			this.AddToolWindow(typeof(EndpointDesignExplorerToolWindow));

			// Initialize Extension Registars
			// this is a partial method call
			this.InitializeExtensions();

			// Add dynamic toolbox items
			this.SetupDynamicToolbox();
		}

		/// <summary>
		/// Partial method to initialize ExtensionRegistrars (if any) in the DslPackage
		/// </summary>
		partial void InitializeExtensions();
		
		/// <summary>
		/// Returns any dynamic tool items for the designer
		/// </summary>
		/// <remarks>The default implementation is to return the list of items from the generated toolbox helper.</remarks>
		protected override global::System.Collections.Generic.IList<DslDesign::ModelingToolboxItem> CreateToolboxItems()
		{
			try
			{
				Debug.Assert(toolboxHelper != null, "Toolbox helper is not initialized");
				return toolboxHelper.CreateToolboxItems();
			}
			catch(global::System.Exception e)
			{
				global::System.Diagnostics.Debug.Fail("Exception thrown during toolbox item creation.  This may result in Package Load Failure:\r\n\r\n" + e);
				throw;
			}
		}
		
		
		/// <summary>
		/// Given a toolbox item "unique ID" and a data format identifier, returns the content of
		/// the data format. 
		/// </summary>
		/// <param name="itemId">The unique ToolboxItem to retrieve data for</param>
		/// <param name="format">The desired format of the resulting data</param>
		protected override object GetToolboxItemData(string itemId, DataFormats.Format format)
		{
			Debug.Assert(toolboxHelper != null, "Toolbox helper is not initialized");
		
			// Retrieve the specified ToolboxItem from the DSL
			return toolboxHelper.GetToolboxItemData(itemId, format);
		}
	}

}

//
// Package attributes which may need to change are placed on the partial class below, rather than in the main include file.
//
namespace NServiceBus.Modeling.EndpointDesign
{
	/// <summary>
	/// Double-derived class to allow easier code customization.
	/// </summary>
	[VSShell::ProvideMenuResource("1000.ctmenu", 2)]
	[VSShell::ProvideToolboxItems(1)]
	[VSTextTemplatingHost::ProvideDirectiveProcessor(typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDirectiveProcessor), global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDirectiveProcessor.EndpointDesignDirectiveProcessorName, "A directive processor that provides access to EndpointDesign files")]
	[global::System.Runtime.InteropServices.Guid(Constants.EndpointDesignPackageId)]
	public partial class EndpointDesignPackage : EndpointDesignPackageBase
	{
	}
}