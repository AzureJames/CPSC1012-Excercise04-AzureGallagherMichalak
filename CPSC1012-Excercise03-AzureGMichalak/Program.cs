/*
 * DOCUMENTATION
 * 
 * Purpose: Convert from one unit to another
 * 
 * Input: A,B,C which unit to convert, and amount of that unit
 * 
 * Process: Parse input to lowercase,
 * A) inches to centimeters: cm=inches/.39370
 * B) Yards to meters: meters = yards/1.0936
 * C) Miles to kilometers: km = miles/.62137
 * 
 * Output: amount of converted unit
 * 
 * Last Modified: Feb 24 2021
 * 
 * Author: Azure Michalak
 * 
 * Test plan:
 * 
 * Test case               test data           expected result             checked
 * inches to centimeters     'A', 1               2.54...                   good
 * yards to meters          'b', 10               9.14...                   good
 * miles to kilometers        'c', 100            160.93...                 good
 * invalid choice             'd', 1             invalid input of d         good
 */

using System;

namespace CPSC1012_Exercise03_AzureMichalak
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountToConvert = 0;
            double outputUnit;
            bool loopProgram = true;
            char userLetterChoice = 'a';
            Console.WriteLine("Unit Converter");

            while (loopProgram == true)
            {

                bool inputCorrect = false;
                while (inputCorrect==false)
                {
                   
                        Console.WriteLine("Choose from these conversions:");
                        Console.WriteLine("A: Inches to Centimeters");
                        Console.WriteLine("B: Yards to Meters");
                        Console.WriteLine("C: Miles to Kilometers");
                        try
                        {
                            userLetterChoice = char.Parse(Console.ReadLine());
                            Char.ToLower(userLetterChoice);
                            inputCorrect = true;
                        }
                        catch
                        {
                            Console.WriteLine("Input error.");
                        }
                }
            

                //now we have a char for the letter choice
                Console.WriteLine("Enter the amount of the unit to convert:");
                //amountToConvert = double.Parse(Console.ReadLine());
            

                outputUnit = 0;
                    switch (userLetterChoice)
                    {
                        case 'a':
                            {
                                //inches to centimeters
                                bool convertInput = false;
                                while (convertInput == false)
                                {
                                    try
                                    {
                                        amountToConvert = double.Parse(Console.ReadLine());
                                        convertInput = true;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Input Error. Enter a number.");
                                        Console.WriteLine("Enter the amount of the unit to convert:");
                                    }
                                }


                                outputUnit = amountToConvert / .39370;
                                Console.WriteLine($"Input inches: {amountToConvert}");
                                Console.WriteLine($"Output centimeters: {outputUnit}\n");
                                break;
                            }
                        case 'b':
                            {   //yards to meters
                                bool convertInput = false;
                                while (convertInput == false)
                                {
                                    try
                                    {
                                        amountToConvert = double.Parse(Console.ReadLine());
                                        convertInput = true;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Input Error. Enter a number.");
                                        Console.WriteLine("Enter the amount of the unit to convert:");
                                    }
                                }
                                outputUnit = amountToConvert / 1.0936;
                                Console.WriteLine($"Input yards: {amountToConvert}");
                                Console.WriteLine($"Output meters: {outputUnit}\n");
                                break;
                            }
                        case 'c':
                            {   //miles to kilometers
                                bool convertInput = false;
                                while (convertInput == false)
                                {
                                    try
                                    {
                                        amountToConvert = double.Parse(Console.ReadLine());
                                        convertInput = true;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Input Error. Enter a number.");
                                        Console.WriteLine("Enter the amount of the unit to convert:");
                                    }
                                }
                                outputUnit = amountToConvert / .62137;
                                Console.WriteLine($"Input miles: {amountToConvert}");
                                Console.WriteLine($"Output kilometers: {outputUnit}\n");
                                break;
                            }
                        case 'A':
                            {
                                //inches to centimeters
                                bool convertInput = false;
                                while (convertInput == false)
                                {
                                    try
                                    {
                                        amountToConvert = double.Parse(Console.ReadLine());
                                        convertInput = true;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Input Error. Enter a number.");
                                        Console.WriteLine("Enter the amount of the unit to convert:");
                                    }
                                }
                                outputUnit = amountToConvert / .39370;
                                Console.WriteLine($"Input inches: {amountToConvert}");
                                Console.WriteLine($"Output centimeters: {outputUnit}\n");
                                break;
                            }
                        case 'B':
                            {   //yards to meters
                                bool convertInput = false;
                                while (convertInput == false)
                                {
                                    try
                                    {
                                        amountToConvert = double.Parse(Console.ReadLine());
                                        convertInput = true;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Input Error. Enter a number.");
                                        Console.WriteLine("Enter the amount of the unit to convert:");
                                    }
                                }
                                outputUnit = amountToConvert / 1.0936;
                                Console.WriteLine($"Input yards: {amountToConvert}");
                                Console.WriteLine($"Output meters: {outputUnit}\n");
                                break;
                            }
                        case 'C':
                            {   //miles to kilometers
                                bool convertInput = false;
                                while (convertInput == false)
                                {
                                    try
                                    {
                                        amountToConvert = double.Parse(Console.ReadLine());
                                        convertInput = true;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Input Error. Enter a number.");
                                        Console.WriteLine("Enter the amount of the unit to convert:");
                                    }
                                }
                                outputUnit = amountToConvert / .62137;
                                Console.WriteLine($"Input miles: {amountToConvert}");
                                Console.WriteLine($"Output kilometers: {outputUnit}\n");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid choice of: " + userLetterChoice);
                            }
                            break;
                    }
            }
        }
    }
}
