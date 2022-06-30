// See https://aka.ms/new-console-template for more information
using System;

namespace StoryTeller
{
    class Program
    {
        /// <summary>
        /// string name=null, favColor=null, favAnimal=null, favBand=null;
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="animal"></param>
        /// <param name="band"></param>
        

        static void tellStory() //string name, var color, string animal, string band)
        {
            //var name = "", color = "", animal = "", band = "";

            Console.Write("What is you name? ");
            var name = Console.ReadLine();
            Console.Write("What is you favorite color? ");
            var color = Console.ReadLine();
            Console.Write("What is you favorite animal? ");
            var animal = Console.ReadLine();
            Console.Write("What is you favorite band? ");
            var band = Console.ReadLine();

            Console.WriteLine("And here's your story:");
            Console.WriteLine("A Day at the Zoo");
            Console.WriteLine("Last week, I went to the zoo.");
            Console.WriteLine("The weirdest thing is that I met a {0} {1} in a cage.",color,animal);
            Console.WriteLine("What's even weirder is that the {0} said: 'Hello, {1}'.",animal, name);
            Console.WriteLine("I asked if he was talking to me. I got no reply.");
            Console.WriteLine("On the way home, the radio played a song by {0}.",band);
            Console.WriteLine("So I guess it was a pretty good day.");

        }
        static void Main(string[] args)
        {
            //string name="", favColor="", favAnimal="", favBand="";

            tellStory(); // name, favColor, favAnimal, favBand);
        }
    }
}