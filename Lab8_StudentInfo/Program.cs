using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            //Declare all Array elements for StudentID, Hometown and FavoriteFood
            string[] Student = {"Peter Parker", "Steve Rogers", "Luke Cage", "Matt Murdock",
            "Jessica Jones", "James Bucky Barnes", "Bruce Banner", "King T'Challa",
            "Peter J. Quill", "I Am Groot", "Gamora Titan", "Thanos Titan",
            "Silver Surfer", "Adam Warlock", "Drax Destroyer", "Okoye J'Kwali",
            "Nakia Q'Noma", "Princess Shuri", "Wanda Maximoff", "Thor Odinson"};

            string[] HometownLocation = {"Queens, NY", "Brooklyn, NY", "Harlem, NY", "Hell's" +
            "Kitchen, NY", "Forest Hills, NY", "Brooklyn, NY", "Dayton, OH", "Capital City," +
            "Wakanda", "St. Charles, MO", "Planet X", "Planet Titan", "Planet Titan", "Zenn-La," +
            "Deneb", "Cosmic Cube, Omniversal", "Burbank, CA", "Capital City, Wakanda",
            "Capital City, Wakanda", "Capital City, Wakanda", "Mt. Wundagore, Transia",
            "Asgard, Omniverse"};

            string[] TopFood = {"Pizza", "Coney Island", "Steak, Medium", "Sushi",
            "Beer Nuts", "Loose Burger", "Bison Burger", "Curry Chicken", "Spaghetti",
            "Avacados", "Chicken Fried Rice", "Beef BBQ Ribs", "Egg Rolls", "Tacos",
            "Beef Burritos", "Chili Con Corne", "Hoisin Chicken", "Chicken Tenders",
            "Beer Battered Cod with Fries", "Lemon Pepper Roasted Chicken"};

            //Introduce user
            Console.WriteLine("Welcome to our C# Class.");
            bool success = true;
            while (success)
            {
                //Ask user to select student
                Console.WriteLine("Which student would you like to learn more about?");
                Console.WriteLine("Please enter a number from 1-20: ");
                //Returns users student selection designated as StudentID
                string StudentID = Console.ReadLine();

                //Call ValidStudent Method, should return an int value
                int Choosen = ValidStudent(StudentID);


                //take returned int value and locate that student
                //we subtract 1 to line up with our array
                Console.WriteLine($"Student {StudentID} is {Student[Choosen - 1]}.");



                Console.WriteLine($"\nWould you like to know about {Student[Choosen - 1]}'s Hometown or Favorite Food?");
                Console.WriteLine($"Select either 'hometown' or 'favorite food':");
                string KnowMore = Console.ReadLine().ToLower();


                {
                    while (success)
                        if (KnowMore != "hometown" && KnowMore != "favorite food")
                        {
                            Console.WriteLine($"\nSorry, that's an invalid response");
                            Console.WriteLine($"Select either 'hometown' or 'favorite food':");
                            KnowMore = Console.ReadLine().ToLower();
                        }
                        else if (KnowMore == "hometown")
                        {
                            Console.WriteLine($"{Student[Choosen - 1]} is from {HometownLocation[Choosen - 1]}.");
                            success = false;
                        }

                        else if (KnowMore == "favorite food")
                        {
                            Console.WriteLine($"{Student[Choosen - 1]} is from {TopFood[Choosen - 1]}.");
                            success = false;
                        }
                }
                success = true;

                Console.WriteLine($"\nWould you like to know more about another student? enter y or n):");
                string GoOn = Console.ReadLine();
                if (GoOn == "n")
                {
                    success = false;
                }

            }
            Console.WriteLine("Please press enter to exit...");
            Console.ReadKey();
        }

        public static int ValidStudent(string Input)
        {
            int Num1;
            while (true)
            {
                //try to make string input a valid number
                if (!int.TryParse(Input, out Num1))
                {
                    Console.WriteLine("Sorry, that student does not exist.");
                    Console.WriteLine("Please try again. (enter a number 1-20):");
                    Input = Console.ReadLine();
                }
                //see if valid number is in a certain range
                else if (Num1 < 1 || Num1 > 20)
                {
                    Console.WriteLine("Sorry, that student does not exist.");
                    Console.WriteLine("Please try again. (enter a number 1-20):");
                    Input = Console.ReadLine();

                }
                else
                {
                    return Num1;
                }
            }
        }
    }
}
