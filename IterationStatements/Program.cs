namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below

        //Write a method that will print to the console all numbers 1000 through - 1000
        //public static int Ceiling ()//; (int num1,int num2)
        //{
        //    Math.Ceiling = 1000;
        //    int floor = -1000;
        //    do         
        //    {
        //        Console.WriteLine(int);
        //    }
        //    while (i < 100) && (i > -1000);


        //}

        //public static void Print1000()

        //{
        //    for (int i = 1000; i >= -1000; i--)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}


        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //public static void PrintBy3()
        //{
        //    for (int i = 0; i <=999; i+=3)
        //    {
        //        Console.WriteLine(i);
        //    }

        //}

        //Write a method to accept two integers as parameters and check whether they are equal or not
        public static void AreTheyEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} is equal to {num2}");
            }
            else
                Console.WriteLine($"{num1} is NOT equal to {num2}");
            }





//Write a method to check whether a given number is even or odd

        public static void EvenOrOdds(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is SO even");
            }
            else
                Console.WriteLine($"{num} is SO odd");
            }

 


        //Write a method to check whether a given number is positive or negative
        public static void PosOrNeg(int num)
        { 
            if (num < 0)
            {
                Console.WriteLine($"{num} is negative");
            }
            else
                Console.WriteLine($"{num} is positive obviously");
            }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void CandidateAge()
        {
            Console.WriteLine("Enter your age");
            var response = int.Parse(Console.ReadLine());

            if (response >= 18)
            {
                Console.WriteLine("You can vote");
            }
            else 
            { 
                Console.WriteLine("Not eligible to vote.");
            }

        }


        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void IntRangeCheck()
        {
            Console.WriteLine("Enter a random number between -10 and 10");
            var response = int.Parse(Console.ReadLine());

            if (response >= -10 && response <= 10   )
            {
                Console.WriteLine("The number is in range");
            }
            else
            {
                Console.WriteLine("The number is out of range");
            }

        }


        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultTTableDisplay(int num)
        {
            for (int i = 1; i < 12; i++)
            {
                Console.WriteLine($"{i} x {num} = {num * i}");
            }

        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //Print1000();
           // PrintBy3();
            AreTheyEqual(3, 4);
            EvenOrOdds(4);
            EvenOrOdds(5);
            PosOrNeg(2);
            PosOrNeg(-5);
            //CandidateAge();
            //IntRangeCheck();
            MultTTableDisplay(12);
        }
    }
}
