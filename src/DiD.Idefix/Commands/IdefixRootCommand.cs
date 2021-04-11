using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using DiD.Idefix.Animations;
using DiD.Idefix.Commands.Base;
using DiD.Idefix.Extensions;

namespace DiD.Idefix.Commands
{
    internal class IdefixRootCommand : RootCommand, IIdefixCommand
    {
        public IdefixRootCommand()
        {
            this.Description = "Shows Idefix as Ascii art";
            this.Handler = CommandHandler.Create(async (IAnimationFactory animations) => await animations.ShowIdefixAsync());
            this.AddChildCommands(ChildCommands());
        }

        public IEnumerable<IdefixCommandBase> ChildCommands()
        {
            yield return new WiggleCommand();
            yield return new OwnerCommand();
            yield return new Tool.ToolCommand();
        }
    }
}