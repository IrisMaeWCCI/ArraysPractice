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
            Console.WriteLine("{0},{1},{2},{3}", firstLetterNames[0], firstLetterNames[1], firstLetterNames[2], firstLetterNames[3]);
            //New Section After Commit of Severl In-CLass Practice Problems
            int[] numberOfSeats = new int[21];
            string[] studentsInClass = new string[21];
            //the pattern I will follow is below
            //nameOfArray[index] = Element;
            Console.WriteLine("\nPlease enter in the name of the next student.");
            studentsInClass[1] = Console.ReadLine();

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
            //the user's information exists only within the console application
            //those values in the array become null outside of the console/once the the app ends
            //the only values that are stored are those that are hardcoded in visual studios

            string[] restaurantsInMall = { "Subway", "Saki", "Dunkin' Donuts", "Red Lobster", "Chic-Fil-A" };
            //For review 
            char[] lettersInFirstName = { 'D', 'a', 'n', 'i', 'e', 'l' };
            //Declare and initialize an array when when I don't know the elements, but I know how many there will be
            //...and print the number of the char's to the Console.
            string[] variableName = new string[42];

            //To pracitce using.Length, create a char array of the letters in your middle name
            //...and print the number of char's to the Console.
            char[] middleName = { 'm', 'a', 'e' };
            Console.WriteLine("\n" + middleName.Length);
            //a property is a tool that a class can use

            //Declare and initialize a string array
            //Using the Length property, print the second to last element in the array
            string[] stringArray = { "Hello", "there", "I'm", "Willa!", "Who", "are", "you?" };
            Console.WriteLine("The length of my array is " + (stringArray.Length - 2));


            string[] stringArrayy = { "Hello", "there", "I'm", "Willa!", "Who", "are", "you?" };
            Console.WriteLine("The length of my array is " + (stringArray.Length - 2));

            string[] restaurantsInMalls = { "Subway", "Saki", "Dunkin' Donuts", "Red Lobster", "Chic-Fil-A" };
            int numRestaurants = restaurantsInMall.Length;
            Console.WriteLine(restaurantsInMalls[numRestaurants - 2]);
            //or
            Console.WriteLine(restaurantsInMalls[restaurantsInMalls.Length - 2]);
            //what's happening above? restaurantsInMalls--->[5-2] (and here you subtract two because this is "Zero Indexed")
            // restaurantsInMalls [3]
            //Console.WriteLine(restaurantsInMalls[restaurantsInMalls.Length); This will get you a system out of range exception because it will be outside of the bounds
            //of your array
            //build time errors
            //run time error these dont show up until youve run your code

            //Index of is a method used to search an array for a specified value
            //and returns the index position of the first matching value found.
            int[] bestYearsEver = { 1985, 1999, 1991, 2000, 1985 };
            Console.WriteLine(Array.IndexOf(bestYearsEver, 1985));
            //there are data types and objects, and there is such a thing as being both a datatype and an object - console for ex. is an object
            //it returns the index of the first matching value that you have asked it to find
            //is a method used to search an array for a specified value and returns the index position of the Last matching value found.
            Console.WriteLine(Array.LastIndexOf(bestYearsEver, 1985));
            //.Length is a property
            //Reverse Method
            int[] palindromeNumbers = {1,2,3,4,5,5,6,7 };
            Console.WriteLine(palindromeNumbers[0]);
            Array.Reverse(palindromeNumbers);
            Console.WriteLine(palindromeNumbers[0]);

        }
    }
}
