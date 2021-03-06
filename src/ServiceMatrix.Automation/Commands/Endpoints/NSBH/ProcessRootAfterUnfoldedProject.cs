﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Composition;
using NuPattern.Runtime;

namespace NServiceBusStudio.Automation.Commands.Endpoints.NSBH
{
    [DisplayName("Process After Unfold On Root")]
    [Description("Process After Unfold On Root Application")]
    [CLSCompliant(false)]
    public class ProcessRootAfterUnfoldedProject : NuPattern.Runtime.Command
    {
        [Required]
        [Import(AllowDefault = true)]
        public IProductElement CurrentElement { get; set; }

        public override void Execute()
        {
            var automation = this.CurrentElement.Root.AutomationExtensions.First(x => x.Name == "SetStartUpProjects");
            automation.Execute();
            automation = this.CurrentElement.Root.AutomationExtensions.First(x => x.Name == "CollapseFolders");
            automation.Execute();
        }
    }
}
