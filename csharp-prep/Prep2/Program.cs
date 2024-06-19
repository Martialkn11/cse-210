using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string answer = Console.ReadLine();
        
        int percent = int.Parse(answer);

        string note ="";

        if(percent == 20)
        {
            note = "Good";
        }
        
        else if(percent >=10)
        {
            note = "Enough good";
        }

        else
        {
            note = "Bad";
        }

        Console.WriteLine($"Your grade is: {note}");

        if(percent>=10)
        {
            Console.WriteLine("You passed!");
        }

        else if(percent<10)
        {
            Console.WriteLine("You do not have a good note so you do not pass.");
        }
    }
}