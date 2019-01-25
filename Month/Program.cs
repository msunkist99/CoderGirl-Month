using System;

namespace Month
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter the number of the month: ");

            // Save the input to a variable.
            string monthNumberString = Console.ReadLine();
            int monthNumber = Convert.ToInt32(monthNumberString);

            // Use the if statment to update the monthName variable based on the user's input.
            string monthName = string.Empty;

            if (monthNumber == 1)
            {
                monthName = "January";
            }
            else if (monthNumber == 2)
            {
                monthName = "February";
            }
            else if (monthNumber == 3)
            {
                monthName = "March";
            }
            else if (monthNumber == 4)
            {
                monthName = "April";
            }
            else if (monthNumber == 5)
            {
                monthName = "May";
            }
            else if (monthNumber == 6)
            {
                monthName = "June";
            }
            else if (monthNumber == 7)
            {
                monthName = "July";
            }
            else if (monthNumber == 8)
            {
                monthName = "August";
            }
            else if (monthNumber == 9)
            {
                monthName = "September";
            }
            else if (monthNumber == 10)
            {
                monthName = "October";
            }
            else if (monthNumber == 11)
            {
                monthName = "November";
            }
            else if (monthNumber == 12)
            {
                monthName = "December";
            }
            else
            {
                monthName = "Unknown";
            }

            Console.WriteLine($"The name of the month you entered is {monthName}");

            Console.ReadLine();
        }
    }
}
