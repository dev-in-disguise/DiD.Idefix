using System.Collections.Generic;
using DiD.Idefix.Commands.Base;
using DiD.Idefix.Extensions;

namespace DiD.Idefix.Commands.Tool
{
    internal class ToolCommand : IdefixCommandBase
    {
        public ToolCommand() : base("tool", "Exposes sub-commands regarding the tool")
        {
            this.AddChildCommands(ChildCommands());
        }

        public override IEnumerable<IdefixCommandBase> ChildCommands()
        {
            yield return new CreatorCommand();
        }
    }
}