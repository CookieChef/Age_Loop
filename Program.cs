using System;

namespace Age_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            //the loop will keep running while the boolean remains true
            while (isRunning)
            {
                //asks the user for their name
                Console.WriteLine("What is your name?");
                var name = Console.ReadLine();

                //asks the user for the date of their birth
                Console.WriteLine("When were you born (MM/DD/YYYY)?");
                var birthDate = Console.ReadLine();

                //converts the value given by the user into the DateTime format
                var birthDate2 = Convert.ToDateTime(birthDate);

                //get the current date and assigns a variable
                var currentDate = DateTime.Today;

                //calculates the users age but only accounting for the year
                var age = currentDate.Year - birthDate2.Year;

                //current date day and month values 
                int day1 = currentDate.Day;
                int month1 = currentDate.Month;

                //users day day and month values
                int day2 = birthDate2.Day;
                int month2 = birthDate2.Month;

                //create conditions to calculate the age accounting for both the day and month
                //if the month and day are the same then say happy birthday
                if (month2 == month1 && day2 == day1)
                {
                    Console.WriteLine("Happy Birthday " + name + "you are " + age + " years old!");
                }
                //if the current month is less than the birthmonth user hasnt had their b-day so age -1 
                else if (month1 < month2)
                {
                    age--;
                    Console.WriteLine("Hello " + name + "you are " + age + " years old!");
                }
                //if the current month is the same as birth month and the current day is less than birthday then age-1 birthday hasnt passed
                else if (month1 == month2 && day1 < day2)
                {
                    age--;
                    Console.WriteLine("Hello " + name + "you are " + age + " years old!");
                }
                //if current month is equal to birth month and the current date is greater than birthday then age because the day passed
                else if (month1 == month2 && day1 > day2)
                {
                    Console.WriteLine("Hello " + name + "you are " + age + " years old!");
                }
                else
                {
                    Console.WriteLine("Hello " + name + "you are " + age + " years old!");
                }

                //if user wants to quit they need to input q
                // if q is read by the console it converts the boolean that runs the while conditional loop to false
                Console.WriteLine("Enter 'q' to quit");
                var quit = Console.ReadLine();
                if (quit == "q")
                {
                    isRunning = false;
                }

            }
        }
    }
}
