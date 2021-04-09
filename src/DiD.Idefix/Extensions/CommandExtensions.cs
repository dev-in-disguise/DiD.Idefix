using System;
using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Invocation;

namespace DiD.Idefix.Extensions
{
    internal static class CommandExtensions
    {
        internal static void AddWiggleCommand(this Command command)
        {
            Command wiggleCommand = new("wiggle", "Shows Ascii art of Idefix wiggling his tail.");
            wiggleCommand.Handler = CommandHandler.Create(async ()=> await AnimationFactory.ShowWigglingIdefixAsync());
            command.Add(wiggleCommand);
        }

        internal static void AddOwnerCommand(this Command command)
        {
            Command ownerCommand = new("owner", "Tells you who the real owner of Idefix is.");
            ownerCommand.Handler = CommandHandler.Create(async ()=> await Console.Out.WriteLineAsync("The owner of Idefix is Obelix, stupid!"));
            command.Add(ownerCommand);
        }

        internal static void AddCreatorCommand(this Command command)
        {
            Command creatorCommand = new("creator", "Tells you who the creator of this dotnet global tool is.");
            creatorCommand.Handler = CommandHandler.Create(async ()=> 
            {
                await Console.Out.WriteLineAsync("Created by a dev-in-disguise.");
                await Console.Out.WriteLineAsync("I'm guessing based on my github profile I'm even worse at disguising myself than Clark Kent...");
            });
            command.Add(creatorCommand);
        }
    }
}