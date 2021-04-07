using System;
using System.Linq;

namespace DiD.Idefix
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!args.Any())
            {
                AnimationFactory.ShowIdefix();
                return;
            }

            if(args.Length > 1)
            {
                Console.WriteLine("Supported idefix commands: ");
                Console.WriteLine(" - idefix");
                Console.WriteLine(" - idefix wiggle");
            }
        }
    }
}
