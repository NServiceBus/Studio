﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Shell;
using NuPattern.Runtime.Guidance.Workflow;
using NuPattern.Runtime.Guidance.Extensions;
using NuPattern.Runtime.Guidance;
using NuPattern.Runtime.Composition;

namespace NServiceBusStudio.Guidance
{
	/// <summary>
	/// Defines a base class for the guidance workflow for this feature.
	/// </summary>
	[CLSCompliant(false)]
	[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Builder", "1.3.21.0")]
	public partial class ProcessWorkflow : GuidanceWorkflow
	{
        /// <summary>
        /// Gets the composition service.
        /// </summary>
        [Import]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        private INuPatternCompositionService Composition { get; set; }

        /// <summary>
        /// Gets whether to ignore all post conditions and enable all actions.
        /// </summary>
        public override bool IgnorePostConditions { get { return true; } }


		/// <summary>
		/// Initializes the workflow.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1809:AvoidExcessiveLocals")]
		protected override void OnInitialize()
		{
			base.OnInitialize();
			this.Name = "GuidanceWorkflow";
			
			this.ConnectTo(new GuidanceWorkflowScrapping().Generate());
			
			this.OnPostInitialize();
		}

		partial void OnPostInitialize();
	}

	/// <summary>
	/// Defines the feature extension containing the guidance workflow.
	/// </summary>
    [GuidanceExtension("23795EC3-3DEA-4F04-9044-4056CF91A2ED", DefaultName = "Working with ServiceMatrix")]
	[Export(typeof(IGuidanceExtension))]
	[PartCreationPolicy(CreationPolicy.NonShared)]
	[CLSCompliant(false)]
	[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Builder", "1.3.21.0")]
    public partial class Feature : BlackboardGuidanceExtension<ProcessWorkflow>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Feature"/> class.
		/// </summary>
		public Feature()
			: base()
		{
		}

		/// <summary>
		/// Gets or sets the ServiceProvider.
		/// </summary>
		[Import]
		public SVsServiceProvider ServiceProvider { get; set; }
	}
}

