using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessFrog.BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Prompt the user for imperial or metric units
                Console.Write("Enter \"metric\" or \"imperial\" for units to be used: ");
                var units = Console.ReadLine();

                if (units.ToLower() == "imperial")
                {
                    Console.Write("Enter weight in pounds: ");
                    var weight = Console.ReadLine();

                    try
                    {
                        var userWeight = double.Parse(weight);

                        if (userWeight <= 0)
                        {
                            Console.WriteLine("Weight must be a positive value.");
                            continue;
                        }
                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("That is not a valid input");
                        continue;
                    }

                    Console.Write("Enter height in inches: ");
                    var height = Console.ReadLine();

                    try
                    {
                        var userHeight = int.Parse(height);

                        if (userHeight <= 0)
                        {
                            Console.WriteLine("Height must be a positive value");
                            continue;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That is not a valid input");
                        continue;
                    }

                    Console.Write("Enter age: ");
                    var age = Console.ReadLine();

                    try
                    {
                        var userAge = int.Parse(age);

                        if (userAge <= 0)
                        {
                            Console.WriteLine("Age must be a positive value");
                            continue;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That is not a valid input");
                        continue;
                    }

                    var bodyMassIndex = 703 * (double.Parse(weight)) / ((int.Parse(height)) * (int.Parse(height)));
                    Console.WriteLine("Your BMI value is " + bodyMassIndex);

                    if ((int.Parse(age) < 18))
                    {
                        if (bodyMassIndex < 5)
                        {
                            Console.WriteLine("According to your BMI, you would be classified as 'Underweight'.");
                        }
                        else if (bodyMassIndex < 85)
                        {
                            Console.WriteLine("According to your BMI, you would be classified as having a 'Healthy Weight'.");
                        }
                        else if (bodyMassIndex < 95)
                        {
                            Console.WriteLine("According to your BMI, you would be classified as 'At Risk of Overweight'.");
                        }
                        else
                        {
                            Console.WriteLine("According to your BMI, you would be classified as 'Overweight'.");
                        }
                    }
                    else
                    {
                        if (bodyMassIndex < 18.5)
                        {
                            Console.WriteLine("According to your BMI, you would be classified as 'Underweight'.");
                        }
                        else if (bodyMassIndex < 25)
                        {
                            Console.WriteLine("According to your BMI, you would be classified as having a 'Normal Weight'.");
                        }
                        else if (bodyMassIndex < 30)
                        {
                            Console.WriteLine("According to your BMI, you would be classified as 'Overweight'.");
                        }
                        else
                        {
                            Console.WriteLine("According to your BMI, you would be classified as 'Obese'.");
                        }
                    }
                }

                else if (units.ToLower() == "metric")
                {
                    {
                        Console.Write("Enter weight in kilograms: ");
                        var weight = Console.ReadLine();

                        try
                        {
                            var userWeight = double.Parse(weight);

                            if (userWeight <= 0)
                            {
                                Console.WriteLine("Weight must be a positive value.");
                                continue;
                            }
                        }

                        catch (FormatException)
                        {
                            Console.WriteLine("That is not a valid input");
                            continue;
                        }

                        Console.Write("Enter height in centimeters: ");
                        var height = Console.ReadLine();

                        try
                        {
                            var userHeight = int.Parse(height);

                            if (userHeight <= 0)
                            {
                                Console.WriteLine("Height must be a positive value");
                                continue;
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("That is not a valid input");
                            continue;
                        }

                        Console.Write("Enter age: ");
                        var age = Console.ReadLine();

                        try
                        {
                            var userAge = int.Parse(age);

                            if (userAge <= 0)
                            {
                                Console.WriteLine("Age must be a positive value");
                                continue;
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("That is not a valid input");
                            continue;
                        }

                        var heightInMeters = ((double.Parse(height)) / 100);
                        var bodyMassIndex = (double.Parse(weight)) / (heightInMeters * heightInMeters);
                        Console.WriteLine("Your BMI value is " + bodyMassIndex);

                        if ((int.Parse(age) < 18))
                        {
                            if (bodyMassIndex < 5)
                            {
                                Console.WriteLine("According to your BMI, you would be classified as 'Underweight'.");
                            }
                            else if (bodyMassIndex < 85)
                            {
                                Console.WriteLine("According to your BMI, you would be classified as having a 'Healthy Weight'.");
                            }
                            else if (bodyMassIndex < 95)
                            {
                                Console.WriteLine("According to your BMI, you would be classified as 'At Risk of Overweight'.");
                            }
                            else
                            {
                                Console.WriteLine("According to your BMI, you would be classified as 'Overweight'.");
                            }
                        }
                        else
                        {
                            if (bodyMassIndex < 18.5)
                            {
                                Console.WriteLine("According to your BMI, you would be classified as 'Underweight'.");
                            }
                            else if (bodyMassIndex < 25)
                            {
                                Console.WriteLine("According to your BMI, you would be classified as having a 'Normal Weight'.");
                            }
                            else if (bodyMassIndex < 30)
                            {
                                Console.WriteLine("According to your BMI, you would be classified as 'Overweight'.");
                            }
                            else
                            {
                                Console.WriteLine("According to your BMI, you would be classified as 'Obese'.");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine(units + " is not an acceptable input.");
                }

                //Prompt the user for their weight
                //Console.Write("Enter weight in pounds/kilograms: ");
                //var weight = Console.ReadLine();

                //Prompt the user for their height
                //Console.Write("Enter height in inches/meters: ");
                //var height = Console.ReadLine();

                //Prompt the user for their age
                //Console.Write("Enter age ");
                //var age = Console.ReadLine();

                //Prompt the user for their sex
                //Console.Write("Enter \"male\" or \"female\" ");
                //var sex = Console.ReadLine();

                //Display BMI
                //Console.WriteLine("You've entered " + units);
                //break;

                //BMI = weight(kg) / height2(m2)(Metric Units)
                //BMI = 703·weight(lb) / height2(in2)(U.S.Units)

                //Over 18
                //Underweight = < 18.5
                //Normal weight = 18.5–24.9
                //Overweight = 25–29.9
                //Obesity = BMI of 30 or greater
            }
        }
    }
}