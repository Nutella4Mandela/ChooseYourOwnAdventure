using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            Console.WriteLine($"It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
            Console.Write("Type YES or NO: ");
            string noiseChoice = Console.ReadLine().ToUpper();
            string doorChoice = "null";
            string riddleAnswer = "null";
            string keyChoice = "null";

            switch (noiseChoice)
            {
                case "YES":
                    Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.\nYou walk towards it. Do you open it or knock?");
                    Console.Write("Type OPEN or KNOCK: ");
                    doorChoice = Console.ReadLine().ToUpper();
                    break;
                case "NO":
                    Console.WriteLine("Not much of an adventure if we don't leave your room!\nTHE END.");
                    break;
            }

            switch (doorChoice)
            {
                case "OPEN":
                    Console.WriteLine("The door is locked! See if one of your keys will open it.");
                    Console.Write("Enter a number (1-3): ");
                    keyChoice = Console.ReadLine().ToUpper();
                    break;
                case "KNOCK":
                    Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle:\"\n\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                    Console.Write("Type your answer: ");
                    riddleAnswer = Console.ReadLine().ToUpper();
                    break;
            }

            switch (riddleAnswer)
            {
                case "NOTHING":
                    Console.WriteLine($"The door opens and {riddleAnswer} is there.\nYou turn off the light and run back to your room and lock the door.\nTHE END.");
                    break;
                default:
                    Console.WriteLine("You answered incorrectly. The door doesn't open.\nTHE END.");
                    break;
            }

            switch (keyChoice)
            {
                case "1":
                    Console.WriteLine("You choose the first key. Lucky choice!\nThe door opens and NOTHING is there. Strange...\nTHE END.");
                    break;
                case "2":
                    Console.WriteLine("You choose the second key. The door doesn't open.\nTHE END.");
                    break;
                case "3":
                    Console.WriteLine("You choose the third key. The door doesn't open.\nTHE END.");
                    break;
            }




        }
    }
}



