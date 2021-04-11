using System.Collections.Generic;

namespace DiD.Idefix.Commands.Base
{
    internal interface IIdefixCommand
    {
        IEnumerable<IdefixCommandBase> ChildCommands();
    }
}