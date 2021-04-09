using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Invocation;
using System.Threading.Tasks;
using System.CommandLine.Parsing;
using DiD.Idefix.Extensions;

namespace DiD.Idefix
{
    class Program
    {
        static Task<int> Main(string[] args) 
            => BuildCommandLine()
                .ConfigureIdefixCommands()
                .UseDefaults()
                .Build()
                .InvokeAsync(args);
        private static CommandLineBuilder BuildCommandLine()
        {
            RootCommand rootCommand = new();
            rootCommand.Description = "Shows Idefix as Ascii art";

            rootCommand.Handler = CommandHandler.Create(async ()=> await AnimationFactory.ShowIdefixAsync()); 
            return new CommandLineBuilder(rootCommand);
        }
    }
}
