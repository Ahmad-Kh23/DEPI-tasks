using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("Student Grade Management System");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Run Lab (Student Grade Management)");
            Console.WriteLine("2. Run  (Temperature Check)");
            Console.WriteLine("3. Run  (Divisible by 3 and 4)");
            Console.WriteLine("4. Run  (Positive or Negative)");
            Console.WriteLine("5. Run (Max and Min of 3 Numbers)");
            Console.WriteLine("6. Run   (Days in Month)");
            Console.WriteLine("7. Run   (Vowel or Consonant)");
            Console.WriteLine("8. Exit");
            Console.WriteLine("========================================");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            Console.WriteLine();

            if (choice == "1")
            {
                RunLab();
            }
            else if (choice == "2")
            {
                Run_1();
            }
            else if (choice == "3")
            {
                Run_2();
            }
            else if (choice == "4")
            {
                Run_3();
            }
            else if (choice == "5")
            {
                Run_4();
            }
            else if (choice == "6")
            {
                Run_5();
            }
            else if (choice == "7")
            {
                Run_6();
            }
            else if (choice == "8")
            {
                Console.WriteLine("Exiting program. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void RunLab()
    {
        Console.WriteLine("=== Lab: Student Grade Management ===\n");

        Console.Write("How many students do you want to register? ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        List<string> studentNames = new List<string>();
        List<int> studentGrades = new List<int>();

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.Write($"Enter student {i + 1} name: ");
            string name = Console.ReadLine();
            studentNames.Add(name);

            Console.Write($"Enter {name}'s grade: ");
            int grade = int.Parse(Console.ReadLine());
            studentGrades.Add(grade);
        }

        int total = 0;
        for (int i = 0; i < studentGrades.Count; i++)
        {
            total += studentGrades[i];
        }
        double averageGrade = (double)total / numberOfStudents;

        int highestGrade = studentGrades[0];
        int lowestGrade = studentGrades[0];

        for (int i = 0; i < studentGrades.Count; i++)
        {
            if (studentGrades[i] > highestGrade)
            {
                highestGrade = studentGrades[i];
            }
            if (studentGrades[i] < lowestGrade)
            {
                lowestGrade = studentGrades[i];
            }
        }

        Console.WriteLine($"\nClass Average Grade: {averageGrade}");
        Console.WriteLine($"Highest Grade: {highestGrade}");
        Console.WriteLine($"Lowest Grade: {lowestGrade}");

        Console.WriteLine("\n--- Student Report ---");
        for (int i = 0; i < numberOfStudents; i++)
        {
            int grade = studentGrades[i];
            string letterGrade;

            if (grade >= 90 && grade <= 100)
            {
                letterGrade = "A";
            }
            else if (grade >= 80 && grade <= 89)
            {
                letterGrade = "B";
            }
            else if (grade >= 70 && grade <= 79)
            {
                letterGrade = "C";
            }
            else if (grade >= 60 && grade <= 69)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            Console.WriteLine($"Name: {studentNames[i]}, Grade: {studentGrades[i]}, Letter: {letterGrade}");
        }

        Console.WriteLine("----------------------");
        Console.WriteLine($"Class Average: {averageGrade}");
        Console.WriteLine($"Highest Grade: {highestGrade}");
        Console.WriteLine($"Lowest Grade: {lowestGrade}");
    }

    static void Run_1()
    {
        Console.WriteLine("===  1: Temperature Check ===\n");

        Console.Write("Enter the temperature: ");
        int temperature = int.Parse(Console.ReadLine());

        string result = temperature < 10 ? "Just Cold" : (temperature > 30 ? "Just Hot" : "Just Good");

        Console.WriteLine(result);
    }

    static void Run_2()
    {
        Console.WriteLine("===  2: Divisible by 3 and 4 ===\n");

        Console.Write("Input: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 3 == 0 && number % 4 == 0)
        {
            Console.WriteLine("Output: Yes");
        }
        else
        {
            Console.WriteLine("Output: No");
        }
    }

    static void Run_3()
    {
        Console.WriteLine("=== 3: Positive or Negative ===\n");

        Console.Write("Input: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Output: negative");
        }
        else if (number == 0)
        {
            Console.WriteLine("Output: zero");
        }
        else
        {
            Console.WriteLine("Output: positive");
        }
    }

    static void Run_4()
    {
        Console.WriteLine("===  4: Max and Min of 3 Numbers ===\n");

        Console.WriteLine("Input:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        int maxElement = num1;
        int minElement = num1;

        if (num2 > maxElement)
        {
            maxElement = num2;
        }
        if (num3 > maxElement)
        {
            maxElement = num3;
        }

        if (num2 < minElement)
        {
            minElement = num2;
        }
        if (num3 < minElement)
        {
            minElement = num3;
        }

        Console.WriteLine("Output:");
        Console.WriteLine($"max element = {maxElement}");
        Console.WriteLine($"min element = {minElement}");
    }

    static void Run_5()
    {
        Console.WriteLine("===  5: Days in Month ===\n");

        Console.Write("Month Number: ");
        int monthNumber = int.Parse(Console.ReadLine());

        int days = 0;

        if (monthNumber == 1)
        {
            days = 31;
        }
        else if (monthNumber == 2)
        {
            days = 28;
        }
        else if (monthNumber == 3)
        {
            days = 31;
        }
        else if (monthNumber == 4)
        {
            days = 30;
        }
        else if (monthNumber == 5)
        {
            days = 31;
        }
        else if (monthNumber == 6)
        {
            days = 30;
        }
        else if (monthNumber == 7)
        {
            days = 31;
        }
        else if (monthNumber == 8)
        {
            days = 31;
        }
        else if (monthNumber == 9)
        {
            days = 30;
        }
        else if (monthNumber == 10)
        {
            days = 31;
        }
        else if (monthNumber == 11)
        {
            days = 30;
        }
        else if (monthNumber == 12)
        {
            days = 31;
        }

        Console.WriteLine($"Days in Month: {days}");
    }

    static void Run_6()
    {
        Console.WriteLine("===  6: Vowel or Consonant ===\n");

        Console.Write("Input: ");
        string input = Console.ReadLine();
        char character = input[0];

        char charLower = char.ToLower(character);

        if (charLower == 'a' || charLower == 'e' || charLower == 'i' || charLower == 'o' || charLower == 'u')
        {
            Console.WriteLine("Output: vowel");
        }
        else
        {
            Console.WriteLine("Output: Consonant");
        }
    }
}