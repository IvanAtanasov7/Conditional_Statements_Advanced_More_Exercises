using System;

namespace _06._Truck_Driver
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string season = Console.ReadLine();
			double kilometers = double.Parse(Console.ReadLine());
			double pricePerKm = 0;

			switch (season)
			{
				case "Spring":
				case "Autumn":

					if (kilometers <= 5000)
					{
						pricePerKm = 0.75;
					}
					else if (kilometers <= 10000)
					{
						pricePerKm = 0.95;
					}
					else if (kilometers <= 20000)
					{
						pricePerKm = 1.45;
					}
					break;

				case "Summer":
					if (kilometers <= 5000)
					{
						pricePerKm = 0.90;
					}
					else if (kilometers <= 10000)
					{
						pricePerKm = 1.10;
					}
					else if (kilometers <= 20000)
					{
						pricePerKm = 1.45;
					}
					break;

				case "Winter":
					if (kilometers <= 5000)
					{
						pricePerKm = 1.05;
					}
					else if (kilometers <= 10000)
					{
						pricePerKm = 1.25;
					}
					else if (kilometers <= 20000)
					{
						pricePerKm = 1.45;
					}
					break;					
			}

			double salary = kilometers * pricePerKm;
			double salaryAfterTax = salary * 4 * 0.9;

            Console.WriteLine($"{salaryAfterTax:F2}");
        }
	}
}
