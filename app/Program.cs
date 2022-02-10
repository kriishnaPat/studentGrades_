using System;
using System.Linq;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //initalizes an array with 50 random grades
            int[] grades = new int[50];
                for (int i = 0; i < grades.Length; i++)
                {
                    grades[i] = rnd.Next(0,101);
                }

            while (true){
                //diplays menu options
                Console.WriteLine(@"
    1.Display All Grades
    2.Randomize Grades
    3.Stats
    4.Count Honours
    5.Exit
");
                //prompting user for input then converting the user input to integer 
                Console.Write("Enter the number for your choice: ");
                int user_choice = Convert.ToInt32(Console.ReadLine());

                //Providing results based on user input
                if (user_choice == 1)
                {
                    //Displays all array elements
                   for (int i = 0; i < grades.Length; i++ ){
                        Console.WriteLine(grades[i]);
                    }
                } 
                else if (user_choice == 2)
                {
                    //changes all array elements
                    for (int i = 0; i < grades.Length; i++)
                    {
                        grades[i] = rnd.Next(0,101);
                    }
                    Console.Write(grades.Length);
                }
                else if (user_choice == 3) 
                {
                    //prints max value, min value, and average value of array
                    int maxValue = grades.Max();
                    int minValue = grades.Min();
                    int avgValue = grades.Sum()/grades.Length;
                    Console.WriteLine($@"
Here is the average grade: {avgValue} 
Here is the highest grade: {maxValue}
Here is the lowest grade:  {minValue}");
                    
                }
                else if (user_choice == 4)
                {
                    //counts how many grades are above 80
                    int sum = 0;
                    for (int i = 0; i < grades.Length; i++ ){
                        if (grades[i] >= 80){
                            sum++;
                        }
                    }
                    Console.WriteLine("Total number of students who recieved honours is: " + sum);
                }
                else if (user_choice == 5)
                {
                    //breaks out of the while loop
                    break;
                }
                else 
                {
                    //lets user know if there choice is not an option
                    Console.Write("Invalid choice");
                }

            }
        }
    }
}
