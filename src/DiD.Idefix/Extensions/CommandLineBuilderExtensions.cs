using System.CommandLine.Builder;

namespace DiD.Idefix.Extensions
{
    internal static class CommandLineBuilderExtensions
    {
        internal static CommandLineBuilder ConfigureIdefixCommands(this CommandLineBuilder builder)
        {
            builder.Command.AddWiggleCommand();
            builder.Command.AddOwnerCommand();
            builder.Command.AddCreatorCommand();

            return builder;
        }
    }
}