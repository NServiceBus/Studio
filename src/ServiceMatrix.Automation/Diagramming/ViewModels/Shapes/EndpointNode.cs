﻿using Mindscape.WpfDiagramming;
using Mindscape.WpfDiagramming.Foundation;
using ServiceMatrix.Diagramming.ViewModels.BaseViewModels;
using NuPattern.Runtime.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ServiceMatrix.Diagramming.ViewModels.Shapes
{
    public class EndpointNode: GroupNode
    {
        public EndpointNode(IProductElementViewModel innerViewModel) : base (innerViewModel)
        {
            this.SHAPE_MIN_HEIGHT = 190;
            this.Bounds = new System.Windows.Rect(0, 0, 320, this.SHAPE_MIN_HEIGHT);
        }

        public string Type 
        {
            get
            {
                switch (this.InnerViewModel.Data.Info.Name)
                {
                    case "NServiceBusHost":
                        return "(NSB Host)";
                        break;
                    case "NServiceBusMVC":
                        return "(ASP.NET MVC)";
                        break;
                }

                return "";
            }
        }
    }
}
