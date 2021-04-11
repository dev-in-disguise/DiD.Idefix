using System.Collections.Generic;
using System.CommandLine;

namespace DiD.Idefix.Extensions
{
    internal static class CommandExtensions
    {
        internal static void AddChildCommands(this Command command, IEnumerable<Command> childCommands)
        {
            foreach (Command childCommand in childCommands)
            {
                command.Add(childCommand);
            }
        }
    }
}