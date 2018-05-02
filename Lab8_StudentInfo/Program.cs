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
            //Ask user to select student
            Console.WriteLine("Which student would you like to learn more about?");
            Console.WriteLine("Please enter a number from 1-20: ");

            string StudentID = Console.ReadLine();
            
            //Call ValidStudent Method
            //int Choosen = ValidStudent(StudentID);

            int i;
            int.TryParse(StudentID, out i);
            i--;

            //Connects the Student(Element) with the Index number 
            for (i = 0; i < StudentID.Length; i++)
            {
                Console.WriteLine($"Student {StudentID[i]} is {Student[i]}.");
            }


            Console.WriteLine($"\nWould you like to know about {Student[i]}'s Hometown or Favorite Food?");
            Console.WriteLine($"Select either 'hometown' or 'favorite food':");
            Console.ReadLine().ToLower();

            string ChoseFood = "FavoriteFood";
            ChoseFood = Console.ReadLine();

            string ChoseHome = "Hometown";
            ChoseHome = Console.ReadLine();

            if (ChoseFood == "FavoriteFood")
            {
                Console.WriteLine($"{Student[i]} is from {HometownLocation[i]}.");
                Console.WriteLine($"Would you like to know more about {Student[i]}? (enter hometown or food):");
            }
            else if (ChoseHome == "Hometown")
            {
                Console.WriteLine($"{Student[i]} likes {TopFood[i]}.");
                Console.WriteLine($"Would you like to know more about {Student[i]}? enter y or n):");
                string GoOn = Console.ReadLine();
                if (GoOn == "n")
                {
                    return;
                }
            }
            else
            {
                Console.WriteLine("That data does not exist. Please try again.");
                Console.WriteLine("Press enter or 'hometown' or 'favorite food.");
            }
            
            Console.WriteLine("Please press enter to exit...");

            Console.ReadKey();
        }
        
        //public static int ValidStudent(string Input)
        //{
        //    int Num1;
        //    while (!int.TryParse(Input, out Num1))
        //    {
        //        Console.WriteLine("Sorry, that student does not exist.");
        //        Console.WriteLine("Please try again. (enter a number 1-20):");
        //        Input = Console.ReadLine();
        //    }
        //    return Num1;
       
        //}
    }
}
