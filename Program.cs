using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring an array without initializing
            int[] myFirstArray;
            //declaring and initializing an array
            string[] myStringArray = { "First", "second", "third", "fourth" };
            //declaring and initialize a char array with the letters of your last name
            char[] myCharArray = { 'H', 'i', 'c', 'k', 's' };
            //I want my console to print three elements of my array
            Console.WriteLine(myCharArray[0]);
            Console.WriteLine(myCharArray[1]);
            Console.WriteLine(myCharArray[2]);
            Console.WriteLine(myCharArray[3]);
            Console.WriteLine(myCharArray[4]);
            //Create the followiing arrays and print the correct index numbers
            //Array of the top 10 vacation spots
            //print the first and last vacation spots
            //Array of the ages of 3 children you know
            // print each child's age
            //Array of GPA's on a 4.0 scale of 8 students- you don't have to print
            //Array of the 1st letter of 4 of your classmate's names who are sitting near you
            //print all four on the same line

            string[] vacationSpots = { "Venice", "Santa Ana", "Hawaii", "Miami", "Barbados", "Cuba", "Costa Rica", "Dominican Republic", "Ghana", "Somalia" };
            Console.WriteLine(vacationSpots[0]);
            Console.WriteLine(vacationSpots[9]);

            int[] ageOfYouths = { 1, 3, 4 };
            Console.WriteLine(ageOfYouths[0]);
            Console.WriteLine(ageOfYouths[1]);
            Console.WriteLine(ageOfYouths[2]);

            int[] GPA = { 100, 87, 99, 65, 72, 90, 69, 85 };

            char[] firstLetterNames = { 'P', 'H', 'B', 'M' };
            Console.Write(firstLetterNames[0]);
            Console.Write(firstLetterNames[1]);
            Console.Write(firstLetterNames[2]);
            Console.Write(firstLetterNames[3]);
            Console.WriteLine(firstLetterNames);

            Console.WriteLine("{0},{1},{2},{3}");//take the variable at the index of zero and print it 
            Console.WriteLine("{0},{1},{2},{3}", firstLetterNames[0],firstLetterNames[1],firstLetterNames[2],firstLetterNames[3]);
            //New Section After Commit of Severl In-CLass Practice Problems
            int[] numberOfSeats = new int[21];
            string[] studentsInClass = new string[21];
            //the pattern I will follow is below
            //nameOfArray[index] = Element;
            Console.WriteLine("\nPlease enter in the name of the next student.");
            studentsInClass [1] = Console.ReadLine();

            //Ask user for input
            Console.WriteLine("\nPlease enter the age of the person in the first seat.");

            //Create a new int array with 21 spots and call it ageOfStudentsInClass
            int[] ageOfStudentsInClass = new int[21];

            //Assign the value of the int at the 0 index of ageOfStudentsInClass to ...
            //... the user's input converted into an int
            ageOfStudentsInClass[0] = int.Parse(Console.ReadLine());

            //Create a new string variable and set it equal to the int at the index of 0 ...
            //and convert it into a string
            string firstIndex = ageOfStudentsInClass[0].ToString();
            Console.WriteLine("\nThe age of the person in the first seat is " + ageOfStudentsInClass[0]);//arrays are immutable, they stay the same size
            string firstIndex1 = ageOfStudentsInClass[0].ToString();
            //lists are mutable datatypes

        }
    }
}
