using System.CommandLine.Builder;
using DiD.Idefix.Animations;

namespace DiD.Idefix.Extensions
{
    internal static class CommandLineBuilderExtensions
    {
        internal static CommandLineBuilder UseCommandHandlerInjection(this CommandLineBuilder builder)
        {
            builder.UseMiddleware(async (context, next) =>
            {
                // register services here
                context.BindingContext.AddService<IAnimationFactory>(_ => new AnimationFactory());

                await next(context);
            });

            return builder;
        }
    }
}