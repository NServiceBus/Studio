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
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// Design view of your application, where you create your services and messages.
	/// </summary>
	[Description("Design view of your application, where you create your services and messages.")]
	[ToolkitInterface(ExtensionId = "23795EC3-3DEA-4F04-9044-4056CF91A2ED", DefinitionId = "6bc9143a-3e32-4dee-b950-2aa11e4c5f5d", ProxyType = typeof(Design))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.4.24.0")]
	public partial interface IDesign : IToolkitInterface
	{

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		IApplication Parent { get; }

		/// <summary>
		/// Gets the <see cref="IServices"/> contained in this element.
		/// </summary>
		IServices Services { get; }

		/// <summary>
		/// Gets the <see cref="IEndpoints"/> contained in this element.
		/// </summary>
		IEndpoints Endpoints { get; }

		/// <summary>
		/// Gets the <see cref="IContractsProject"/> contained in this element.
		/// </summary>
		IContractsProject ContractsProject { get; }

		/// <summary>
		/// Gets the <see cref="IInternalMessagesProject"/> contained in this element.
		/// </summary>
		IInternalMessagesProject InternalMessagesProject { get; }

		/// <summary>
		/// Gets the <see cref="IInfrastructure"/> contained in this element.
		/// </summary>
		IInfrastructure Infrastructure { get; }

		/// <summary>
		/// Gets the <see cref="IDummyCollection"/> contained in this element.
		/// </summary>
		IDummyCollection DummyCollection { get; }

		/// <summary>
		/// Creates a new <see cref="IServices"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IServices CreateServices(string name, Action<IServices> initializer = null, bool raiseInstantiateEvents = true);

		/// <summary>
		/// Creates a new <see cref="IEndpoints"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IEndpoints CreateEndpoints(string name, Action<IEndpoints> initializer = null, bool raiseInstantiateEvents = true);

		/// <summary>
		/// Creates a new <see cref="IContractsProject"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IContractsProject CreateContractsProject(string name, Action<IContractsProject> initializer = null, bool raiseInstantiateEvents = true);

		/// <summary>
		/// Creates a new <see cref="IInternalMessagesProject"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IInternalMessagesProject CreateInternalMessagesProject(string name, Action<IInternalMessagesProject> initializer = null, bool raiseInstantiateEvents = true);

		/// <summary>
		/// Creates a new <see cref="IInfrastructure"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IInfrastructure CreateInfrastructure(string name, Action<IInfrastructure> initializer = null, bool raiseInstantiateEvents = true);

		/// <summary>
		/// Creates a new <see cref="IDummyCollection"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IDummyCollection CreateDummyCollection(string name, Action<IDummyCollection> initializer = null, bool raiseInstantiateEvents = true);

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IView"/>) of this element.
		/// </summary>
		Runtime.IView AsView();
	}
}
