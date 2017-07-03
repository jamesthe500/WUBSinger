using System;
using System.IO;

namespace WUBSinger
{
    class Program
    {
        public static void Main(string[] args)
        {
            var songs = new string[] { "icantquityou", "endoftheworld", "itsasmallworld" };
            Console.WriteLine("Welcome to Singer!");
            while (true)
            {

                Console.WriteLine("Please choose a song you'd like to sing");
                Console.WriteLine("1 for I can't quit you by Led Zeppelin");
                Console.WriteLine("2 for End of the world");
                Console.WriteLine("3 for It's a small world");
                Console.WriteLine("Type quit to quit the application");


                var response = Console.ReadLine();

                if (response.ToLower() == "quit") { break; }

                var song = 0;

                if (!int.TryParse(response, out song))
                {
                    Console.WriteLine("Invalid input, please try again");
                    continue;
                }

                song--;


                var fileName = "../../" + songs[song] + ".txt";
                /*
                if(!File.Exists(fileName))
                {
                    Console.WriteLine("File not found, try again");
                    continue;
                }*/

                var lines = File.ReadAllLines(fileName);

                Console.WriteLine("===========");
                foreach (var line in lines)
                {
                    Singer.WriteLine(line);
                }
                Console.WriteLine("===========");
            }

        }
    }
}
