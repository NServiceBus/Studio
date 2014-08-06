﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NServiceBusStudio
{
	using global::NuPattern.Runtime;
	using global::NuPattern.Runtime.ToolkitInterface;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Composition;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// Design view of your application, where you create your services and messages.
	/// </summary>
	[Description("Design view of your application, where you create your services and messages.")]
	[ToolkitInterfaceProxy(ExtensionId = "23795EC3-3DEA-4F04-9044-4056CF91A2ED", DefinitionId = "6bc9143a-3e32-4dee-b950-2aa11e4c5f5d", ProxyType = typeof(Design))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.4.24.0")]
	[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
	internal partial class Design : IDesign
	{

		private Runtime.IView target;
		private IContainerProxy<IDesign> proxy;

		/// <summary>
		/// Creates a new instance of the <see cref="Design"/> class.
		/// </summary>
		[ImportingConstructor]
		private Design() { }

		/// <summary>
		/// Creates a new instance of the <see cref="Design"/> class.
		/// </summary>
		public Design(Runtime.IView target)
		{
			this.target = target;
			this.proxy = target.ProxyFor<IDesign>();
			OnCreated();
		}

		/// <summary>
		/// When overridden, initializes the class.
		/// </summary>
		partial void OnCreated();

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		public virtual IApplication Parent
		{
			get { return this.target.Parent.As<IApplication>(); }
		}

		/// <summary>
		/// Gets the <see cref="IServices"/> contained in this element.
		/// </summary>
		public virtual IServices Services
		{
			get { return proxy.GetElement(() => this.Services, element => new Services(element)); }
		}

		/// <summary>
		/// Gets the <see cref="IEndpoints"/> contained in this element.
		/// </summary>
		public virtual IEndpoints Endpoints
		{
			get { return proxy.GetElement(() => this.Endpoints, element => new Endpoints(element)); }
		}

		/// <summary>
		/// Gets the <see cref="IContractsProject"/> contained in this element.
		/// </summary>
		public virtual IContractsProject ContractsProject
		{
			get { return proxy.GetElement(() => this.ContractsProject, element => new ContractsProject(element)); }
		}

		/// <summary>
		/// Gets the <see cref="IInternalMessagesProject"/> contained in this element.
		/// </summary>
		public virtual IInternalMessagesProject InternalMessagesProject
		{
			get { return proxy.GetElement(() => this.InternalMessagesProject, element => new InternalMessagesProject(element)); }
		}

		/// <summary>
		/// Gets the <see cref="IInfrastructure"/> contained in this element.
		/// </summary>
		public virtual IInfrastructure Infrastructure
		{
			get { return proxy.GetElement(() => this.Infrastructure, element => new Infrastructure(element)); }
		}

		/// <summary>
		/// Gets the <see cref="IDummyCollection"/> contained in this element.
		/// </summary>
		public virtual IDummyCollection DummyCollection
		{
			get { return proxy.GetElement(() => this.DummyCollection, element => new DummyCollection(element)); }
		}

		/// <summary>
		/// Creates a new <see cref="IServices"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		public virtual IServices CreateServices(string name, Action<IServices> initializer = null, bool raiseInstantiateEvents = true)
		{
			return proxy.CreateCollection<IServices>(name, initializer, raiseInstantiateEvents);
		}

		/// <summary>
		/// Creates a new <see cref="IEndpoints"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		public virtual IEndpoints CreateEndpoints(string name, Action<IEndpoints> initializer = null, bool raiseInstantiateEvents = true)
		{
			return proxy.CreateCollection<IEndpoints>(name, initializer, raiseInstantiateEvents);
		}

		/// <summary>
		/// Creates a new <see cref="IContractsProject"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		public virtual IContractsProject CreateContractsProject(string name, Action<IContractsProject> initializer = null, bool raiseInstantiateEvents = true)
		{
			return proxy.CreateElement<IContractsProject>(name, initializer, raiseInstantiateEvents);
		}

		/// <summary>
		/// Creates a new <see cref="IInternalMessagesProject"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		public virtual IInternalMessagesProject CreateInternalMessagesProject(string name, Action<IInternalMessagesProject> initializer = null, bool raiseInstantiateEvents = true)
		{
			return proxy.CreateElement<IInternalMessagesProject>(name, initializer, raiseInstantiateEvents);
		}

		/// <summary>
		/// Creates a new <see cref="IInfrastructure"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		public virtual IInfrastructure CreateInfrastructure(string name, Action<IInfrastructure> initializer = null, bool raiseInstantiateEvents = true)
		{
			return proxy.CreateCollection<IInfrastructure>(name, initializer, raiseInstantiateEvents);
		}

		/// <summary>
		/// Creates a new <see cref="IDummyCollection"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		public virtual IDummyCollection CreateDummyCollection(string name, Action<IDummyCollection> initializer = null, bool raiseInstantiateEvents = true)
		{
			return proxy.CreateCollection<IDummyCollection>(name, initializer, raiseInstantiateEvents);
		}

		/// <summary>
		/// Deletes this element.
		/// </summary>
		public virtual void Delete()
		{
			this.target.Delete();
		}

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IView"/>) of this element.
		/// </summary>
		public virtual Runtime.IView AsView()
		{
			return this.target;
		}

		/// <summary>
		/// Gets the specified generalized interface of this element, if possible.
		/// </summary>
		public virtual TGeneralizedInterface As<TGeneralizedInterface>() where TGeneralizedInterface : class
		{
			return this.target as TGeneralizedInterface;
		}
	}
}
