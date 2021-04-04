using System;
using System.IO;

namespace DiD.IdefixGlobal
{
    internal static class AnimationFactory
    {
        internal static void ShowIdefix()
        {
            var idefixAscii = File.ReadAllLines(@".\Resources\Idefix.txt");

            foreach (var asciiLine in idefixAscii)
            {
                Console.WriteLine(asciiLine);
            }
        }
    }
}
