﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using N2.Persistence;

namespace N2.Workflow.Commands
{
    public class UseNewVersionCommand : CommandBase<CommandContext>
    {
        IVersionManager versionMaker;
        public UseNewVersionCommand(IVersionManager versionMaker)
        {
            this.versionMaker = versionMaker;
        }
        public override void Process(CommandContext state)
        {
            state.Data = versionMaker.SaveVersion(state.Data);
        }
    }
}