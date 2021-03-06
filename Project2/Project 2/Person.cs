﻿namespace ConsoleApp1
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;

        public static int Count;
        public static int SumOfAllAges;

        public static double AverageAge()
        {
            return (double)Person.SumOfAllAges / (double)Person.Count;
        }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.GetFullName());
            System.Console.WriteLine(this.Age);
        }
        public void AskUserForNameAndAge()
        {
            System.Console.Write("What's your first Name ?: ");
            this.FirstName = System.Console.ReadLine();

            System.Console.Write("What's your last Name ? : ");
            this.LastName = System.Console.ReadLine();

            System.Console.Write("How old are you ?       : ");
            this.Age = int.Parse(System.Console.ReadLine());

            Person.Count++;
            Person.SumOfAllAges += this.Age;

        }

        public void CreateSpouseIfMarried()
        {
            System.Console.Write("Are you married? (y/n) : ");

            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                this.Spouse = new Person();
                this.Spouse.AskUserForNameAndAge();
                this.Spouse.Spouse = this;
            }
        }
    }
}