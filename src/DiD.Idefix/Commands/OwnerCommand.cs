using System;
using System.CommandLine.Invocation;
using DiD.Idefix.Commands.Base;

namespace DiD.Idefix.Commands
{
    internal class OwnerCommand : IdefixCommandBase
    {
        public OwnerCommand() : base("owner", "Tells you who the real owner of Idefix is.")
        {
            this.Handler = CommandHandler.Create(async () => await Console.Out.WriteLineAsync("The owner of Idefix is Obelix, stupid!"));
        }
    }
}