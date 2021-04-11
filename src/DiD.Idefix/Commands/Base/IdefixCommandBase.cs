using System.Collections.Generic;
using System.CommandLine;
using System.Linq;

namespace DiD.Idefix.Commands.Base
{
    internal abstract class IdefixCommandBase : Command, IIdefixCommand
    {
        protected IdefixCommandBase(string commandName, string description)
            : base(commandName, description)
        {
        }

        public virtual IEnumerable<IdefixCommandBase> ChildCommands() => Enumerable.Empty<IdefixCommandBase>();
    }
}