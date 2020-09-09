using System;

namespace Age_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

        //the loop will keep running while the boolean remains true
        while(isRunning){
            //asks the user for their name
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            //asks the user for the date of their birth
            Console.WriteLine("When were you born (MM/DD/YYYY)?");
            var birthDate = Console.ReadLine ();

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

            //if else statement that compares user date with the current date
            //if the day AND the month is a match wirte the message with date
            //if they dont match just display the age
            if(day1 == day2 && month1 == month2) {
                Console.WriteLine("Happy Birthday " + name + " You are " + age + " years old today!");
            } else {
               Console.WriteLine(name + " you are " + age + " years old");
            }

            //if user hasnt had their birthday account the age for that include the month and day to get the age
            //     is else 



            //if user wants to quit they need to input q
            // if q is read by the console it converts the boolean that runs the while conditional loop to false
            Console.WriteLine("Enter 'q' to quit");
            var quit = Console.ReadLine();
            if (quit == "q") {
                isRunning = false;
            }
            
        }
        }
    }
}
