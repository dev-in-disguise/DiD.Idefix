using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Parsing;
using System.Threading.Tasks;
using DiD.Idefix.Commands;
using DiD.Idefix.Extensions;

namespace DiD.Idefix
{
    class Program
    {
        static Task<int> Main(string[] args)
            => new CommandLineBuilder(new IdefixRootCommand())
                .UseCommandHandlerInjection()
                .UseDefaults()
                .Build()
                .InvokeAsync(args);
    }
}