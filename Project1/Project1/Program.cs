using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name?: ");
            string userFirstName = Console.ReadLine();
            Console.Write("What is your last name?: ");
            string userLastName = Console.ReadLine();
            Console.Write("What is your middle initial?: ");
            string userMiddleInitial = Console.ReadLine();
            string userFullName = userFirstName + " " + userMiddleInitial + "." + userLastName;

            Console.Write("What is your height in feet?(just feet): ");
            int userHeightFeet = int.Parse(Console.ReadLine());
            Console.Write("What is your remaining height in inches?: ");
            double userHeightInches = double.Parse(Console.ReadLine());
            double totalUserHeightInches = (userHeightFeet * 12) + userHeightInches;
            double totalUserHeightCentimeters = totalUserHeightInches * 2.54;

            Console.Write("How old are you?: ");
            int userAge = int.Parse(Console.ReadLine());
            Console.Write("You are a citizen of the United States(True/False):");
            bool isUserCitizen = bool.Parse(Console.ReadLine());
            bool canUserVote = isUserCitizen && userAge >= 18;

            Console.WriteLine(" ");
            Console.WriteLine("Your name is " + userFullName + ".");
            Console.WriteLine("Your height in centimeters is " + totalUserHeightCentimeters + ".");
            Console.WriteLine("You can vote is a " + canUserVote + " statement!");     //if(bool == isUserCitizen && (userAge >= 18)) 

            System.Threading.Thread.Sleep(500000);

        }
    }
}
