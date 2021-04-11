using System;
using System.Threading;
using System.Threading.Tasks;
using DiD.Idefix.Resources;

namespace DiD.Idefix.Animations
{
    internal class AnimationFactory : IAnimationFactory
    {
        public Task ShowIdefixAsync()
        {
            string idefix = IdefixResources.Idefix;
            return Console.Out.WriteLineAsync(idefix);
        }

        public async Task ShowWigglingIdefixAsync()
        {
            await ShowIdefixAsync();
            var tailLeft = IdefixResources.IdefixTailLeft;
            var tailRight = IdefixResources.IdefixTailRight;
            bool isTailRight = true;

            CancellationTokenSource cts = new CancellationTokenSource(2500);

            try
            {
                while (!cts.Token.IsCancellationRequested)
                {
                    var tailToUpdate = isTailRight ? tailLeft : tailRight;
                    Console.Clear();
                    await Console.Out.WriteLineAsync(tailToUpdate);

                    isTailRight = !isTailRight;
                    await Task.Delay(250, cts.Token);
                }
            }
            catch (TaskCanceledException) { }
        }
    }
}
