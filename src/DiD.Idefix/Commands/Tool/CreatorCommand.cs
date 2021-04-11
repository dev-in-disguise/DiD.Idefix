using System;
using System.CommandLine.Invocation;
using DiD.Idefix.Commands.Base;

namespace DiD.Idefix.Commands.Tool
{
    internal class CreatorCommand : IdefixCommandBase
    {
        public CreatorCommand() : base("creator", "Tells you who the creator of this dotnet global tool is.")
        {
            this.Handler = CommandHandler.Create(async () =>
            {
                await Console.Out.WriteLineAsync("Created by a dev-in-disguise.");
                await Console.Out.WriteLineAsync("I'm guessing based on my github profile I'm even worse at disguising myself than Clark Kent...");
            });
        }
    }
}