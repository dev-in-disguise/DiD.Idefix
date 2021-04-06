using System;
using DiD.Idefix.Resources;

namespace DiD.Idefix
{
    internal static class AnimationFactory
    {
        internal static void ShowIdefix()
        {
            string idefix = IdefixResources.Idefix;
            Console.WriteLine(idefix);
        }
    }
}
