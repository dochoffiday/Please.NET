using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Please.NET.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Please.Net.Console STARTED");

            var please = new Please();

            please.Do(() => Console.WriteLine("  -- Here, I am doing things and I asked politely!"));
            please.PrettyPlease(() => Console.WriteLine("  -- Here, I am doing things and I asked with a cherry on top!"), true);
            please.Repeat(20, i => Console.WriteLine("  -- i = " + i));

            while (!please.TellMeIfAllTasksAreCompleted())
            {
                Thread.Sleep(100);
            }
            Console.WriteLine();
            Console.WriteLine("** Please.Net.Console ENDED");
            Console.ReadLine();
        }
    }
}
