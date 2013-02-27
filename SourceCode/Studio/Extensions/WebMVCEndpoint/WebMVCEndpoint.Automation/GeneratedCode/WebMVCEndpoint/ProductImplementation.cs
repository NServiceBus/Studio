﻿
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebMVCEndpoint
{
	using global::NuPattern.Runtime;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Composition;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	///	<summary>
	///	This Endpoint should be abstract, only to be tailored in other endpoints
	///	</summary>
	[Description("This Endpoint should be abstract, only to be tailored in other endpoints")]
	[ToolkitInterfaceProxy(ExtensionId ="e91869eb-ba2e-4420-baad-df72525d4fe5", DefinitionId = "f3d852c6-be54-479c-9017-e48c2cd8f958", ProxyType = typeof(AbstractEndpoint))]
	[System.CodeDom.Compiler.GeneratedCode("Pattern Toolkit Automation Library", "1.2.19.0")]
	[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
	internal partial class AbstractEndpoint : IAbstractEndpoint
	{
		private Runtime.IProduct target;
		private Runtime.IProductProxy<IAbstractEndpoint> proxy;

		/// <summary>
		/// For MEF.
		/// </summary>
		[ImportingConstructor]
		private AbstractEndpoint() { }

		/// <summary>
		/// Initializes a new instance of the <see cref="AbstractEndpoint"/> class.
		/// </summary>
		public AbstractEndpoint(Runtime.IProduct target)
		{
			this.target = target;
			this.proxy = target.ProxyFor<IAbstractEndpoint>();
			OnCreated();
		}	

		partial void OnCreated();

		///	<summary>
		///	Description for AbstractEndpoint.Namespace
		///	</summary>
		[Description("Description for AbstractEndpoint.Namespace")]
		[DisplayName("Namespace")]
		[Category("General")]
		public virtual String Namespace 
		{
			get { return this.proxy.GetValue(() => this.Namespace); }
			set { this.proxy.SetValue(() => this.Namespace, value); }
		}

		///	<summary>
		///	Description for AbstractEndpoint.SLA
		///	</summary>
		[Description("Description for AbstractEndpoint.SLA")]
		[DisplayName("SLA")]
		[Category("General")]
		public virtual String SLA 
		{
			get { return this.proxy.GetValue(() => this.SLA); }
			set { this.proxy.SetValue(() => this.SLA, value); }
		}

		///	<summary>
		///	Description for AbstractEndpoint.MessageEndpointMappingsConfig
		///	</summary>
		[Description("Description for AbstractEndpoint.MessageEndpointMappingsConfig")]
		[DisplayName("Message Endpoint Mappings Config")]
		[Category("General")]
		public virtual String MessageEndpointMappingsConfig 
		{
			get { return this.proxy.GetValue(() => this.MessageEndpointMappingsConfig); }
			set { this.proxy.SetValue(() => this.MessageEndpointMappingsConfig, value); }
		}

		///	<summary>
		///	Description for AbstractEndpoint.CommandSenderNeedsRegistration
		///	</summary>
		[Description("Description for AbstractEndpoint.CommandSenderNeedsRegistration")]
		[DisplayName("Command Sender Needs Registration")]
		[Category("General")]
		public virtual Boolean CommandSenderNeedsRegistration 
		{
			get { return this.proxy.GetValue(() => this.CommandSenderNeedsRegistration); }
			set { this.proxy.SetValue(() => this.CommandSenderNeedsRegistration, value); }
		}

		///	<summary>
		///	Description for AbstractEndpoint.MessageConventions
		///	</summary>
		[Description("Description for AbstractEndpoint.MessageConventions")]
		[DisplayName("Message Conventions")]
		[Category("General")]
		public virtual String MessageConventions 
		{
			get { return this.proxy.GetValue(() => this.MessageConventions); }
			set { this.proxy.SetValue(() => this.MessageConventions, value); }
		}

		///	<summary>
		///	Description for AbstractEndpoint.ErrorQueue
		///	</summary>
		[Description("Description for AbstractEndpoint.ErrorQueue")]
		[DisplayName("Error Queue")]
		[Category("General")]
		public virtual String ErrorQueue 
		{
			get { return this.proxy.GetValue(() => this.ErrorQueue); }
			set { this.proxy.SetValue(() => this.ErrorQueue, value); }
		}

		///	<summary>
		///	Description for AbstractEndpoint.ForwardReceivedMessagesTo
		///	</summary>
		[Description("Description for AbstractEndpoint.ForwardReceivedMessagesTo")]
		[DisplayName("Forward Received Messages To")]
		[Category("General")]
		public virtual String ForwardReceivedMessagesTo 
		{
			get { return this.proxy.GetValue(() => this.ForwardReceivedMessagesTo); }
			set { this.proxy.SetValue(() => this.ForwardReceivedMessagesTo, value); }
		}

		///	<summary>
		///	Description for AbstractEndpoint.NumberOfWorkerThreads
		///	</summary>
		[Description("Description for AbstractEndpoint.NumberOfWorkerThreads")]
		[DisplayName("Number Of Worker Threads")]
		[Category("General")]
		public virtual Int64 NumberOfWorkerThreads 
		{
			get { return this.proxy.GetValue(() => this.NumberOfWorkerThreads); }
			set { this.proxy.SetValue(() => this.NumberOfWorkerThreads, value); }
		}

		///	<summary>
		///	Description for AbstractEndpoint.HasComponentsThatPublishEvent
		///	</summary>
		[Description("Description for AbstractEndpoint.HasComponentsThatPublishEvent")]
		[DisplayName("Has Components That Publish Event")]
		[Category("General")]
		public virtual Boolean HasComponentsThatPublishEvent 
		{
			get { return this.proxy.GetValue(() => this.HasComponentsThatPublishEvent); }
			set { this.proxy.SetValue(() => this.HasComponentsThatPublishEvent, value); }
		}

		///	<summary>
		///	Description for AbstractEndpoint.MaxRetries
		///	</summary>
		[Description("Description for AbstractEndpoint.MaxRetries")]
		[DisplayName("Max Retries")]
		[Category("General")]
		public virtual Int64 MaxRetries 
		{
			get { return this.proxy.GetValue(() => this.MaxRetries); }
			set { this.proxy.SetValue(() => this.MaxRetries, value); }
		}
		
		///	<summary>
		///	The ToolkitInfo.
		///	</summary>
		public virtual IProductToolkitInfo ToolkitInfo 
		{ 
			get { return this.proxy.GetValue(() => this.ToolkitInfo); }
		}
		
		///	<summary>
		///	The CurrentView.
		///	</summary>
		public virtual IView CurrentView 
		{ 
			get { return this.proxy.GetValue(() => this.CurrentView); }
			set { this.proxy.SetValue(() => this.CurrentView, value); }
		}
		
		///	<summary>
		///	The name of this element instance.
		///	</summary>
		[ParenthesizePropertyName(true)]
		[Description("The name of this element instance.")]
		public virtual String InstanceName 
		{ 
			get { return this.proxy.GetValue(() => this.InstanceName); }
			set { this.proxy.SetValue(() => this.InstanceName, value); }
		}
		
		///	<summary>
		///	The order of this element relative to its siblings.
		///	</summary>
		[ReadOnly(true)]
		[Description("The order of this element relative to its siblings.")]
		public virtual Double InstanceOrder 
		{ 
			get { return this.proxy.GetValue(() => this.InstanceOrder); }
			set { this.proxy.SetValue(() => this.InstanceOrder, value); }
		}
		
		///	<summary>
		///	The references of this element.
		///	</summary>
		[Description("The references of this element.")]
		public virtual IEnumerable<IReference> References 
		{ 
			get { return this.proxy.GetValue(() => this.References); }
		}
		
		///	<summary>
		///	Notes for this element.
		///	</summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		public virtual String Notes 
		{ 
			get { return this.proxy.GetValue(() => this.Notes); }
			set { this.proxy.SetValue(() => this.Notes, value); }
		}
		
		///	<summary>
		///	The InTransaction.
		///	</summary>
		public virtual Boolean InTransaction 
		{ 
			get { return this.proxy.GetValue(() => this.InTransaction); }
		}
		
		///	<summary>
		///	The IsSerializing.
		///	</summary>
		public virtual Boolean IsSerializing 
		{ 
			get { return this.proxy.GetValue(() => this.IsSerializing); }
		}

		///	<summary>
		///	Description for AbstractEndpoint.DefaultView
		///	</summary>
		[Description("Description for AbstractEndpoint.DefaultView")]
		public virtual IDefaultView DefaultView
		{ 
			get { return this.proxy.GetView(() => this.DefaultView, view => new DefaultView(view)); }
		}

		/// <summary>
		/// Gets the generic <see cref="Runtime.IProduct"/> underlying element.
		/// </summary>
		public virtual Runtime.IProduct AsProduct()
		{
			return this.target;
		}

		/// <summary>
		/// Gets the generic underlying element as the given type if possible.
		/// </summary>
		public virtual TRuntimeInterface As<TRuntimeInterface>()
			where TRuntimeInterface : class
		{
			return this.target as TRuntimeInterface;
		}

		/// <summary>
		/// Deletes this instance.
		/// </summary>
		public virtual void Delete()
		{
			this.target.Delete();
		}
	}
}