using System.CommandLine.Invocation;
using DiD.Idefix.Animations;
using DiD.Idefix.Commands.Base;

namespace DiD.Idefix.Commands
{
    internal class WiggleCommand : IdefixCommandBase
    {
        public WiggleCommand() : base("wiggle", "Shows Ascii art of Idefix wiggling his tail.")
        {
            this.Handler = CommandHandler.Create(async (IAnimationService animations) => await animations.ShowWigglingIdefixAsync());
        }
    }
}