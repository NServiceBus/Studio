﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Composition;
using NuPattern.Runtime;
using NServiceBusStudio.Automation.Extensions;
using AbstractEndpoint;

namespace NServiceBusStudio.Automation.ValueProviders.Endpoints
{
    [CLSCompliant(false)]
    [DisplayName("ComponentsOrderProvider")]
    [Category("General")]
    [Description("Returns ComponentsOrderProvider")]
    public class ComponentsOrderProvider : ValueProvider
    {
        /// <summary>
        /// Gets or sets the current element.
        /// </summary>
        [Required]
        [Import(AllowDefault = true)]
        public IProductElement CurrentElement
        {
            get;
            set;
        }

        public override object Evaluate()
        {
            return this.CurrentElement.GetComponentsHandlerOrder();
        }
    }
}
