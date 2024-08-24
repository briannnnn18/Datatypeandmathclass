using System;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            //question grades
            double[] grades = new double[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter your grade in subject {i + 1}: ");
                grades[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Computation
            double sum = 0;
            foreach (double grade in grades)
            {
                sum += grade;
            }
            double average = sum / grades.Length;

            // rounding it off
            double roundedAverage = Math.Round(average, 2);

            // resualt
            Console.WriteLine($"Average of the grades: {average:F2}");
            Console.WriteLine($"Rounded average: {roundedAverage:F2}");
            
            Console.WriteLine("Press any key to exit..... ");
            Console.ReadKey();
        }
    }
}