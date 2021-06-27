using System;
using System.Threading;
using System.Threading.Tasks;
using DiD.Idefix.Resources;

namespace DiD.Idefix.Animations
{
    internal class AnimationService : IAnimationService
    {
        public Task ShowIdefixAsync()
        {
            string idefix = IdefixResources.Idefix;
            return Console.Out.WriteLineAsync(idefix);
        }

        public async Task ShowWigglingIdefixAsync()
        {
            Console.CursorVisible = false;
            Console.Clear();
            await ShowIdefixAsync();

            var previousRow = Console.CursorTop;
            var tailLeft = IdefixResources.IdefixTailLeft.Split(Environment.NewLine);
            var tailRight = IdefixResources.IdefixTailRight.Split(Environment.NewLine);
            bool isTailRight = true;

            CancellationTokenSource cts = new CancellationTokenSource(2500);

            try
            {
                while (!cts.Token.IsCancellationRequested)
                {
                    var tailToUpdate = isTailRight ? tailLeft : tailRight;

                    for (int i = 0; i < tailToUpdate.Length; i++)
                    {
                        Console.SetCursorPosition(0, 2 + i);
                        await Console.Out.WriteAsync(tailToUpdate[i]);
                    }

                    isTailRight = !isTailRight;
                    await Task.Delay(250, cts.Token);
                }
            }
            catch (TaskCanceledException) { }

            Console.CursorVisible = true;
            Console.SetCursorPosition(0, previousRow);
        }
    }
}
