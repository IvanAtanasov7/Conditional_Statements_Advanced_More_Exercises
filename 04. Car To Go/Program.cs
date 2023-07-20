using System;

namespace _04._Car_To_Go
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double budget = double.Parse(Console.ReadLine());
			string season = Console.ReadLine();
			string typeCar = "";
			string typeClass = "";
			double price = 0;

			if (budget <= 100)
			{
				typeClass = "Economy class";

				if (season == "Summer")
				{
					typeCar = "Cabrio";
					price = budget * 0.35;
				}
				else if (season == "Winter")
				{
					typeCar = "Jeep";
					price = budget * 0.65;
				}
			}
			else if (budget > 100 && budget <= 500)
			{
				typeClass = "Compact class";

				if (season == "Summer")
				{
					typeCar = "Cabrio";
					price = budget * 0.45;
				}
				else if (season == "Winter")
				{
					typeCar = "Jeep";
					price = budget * 0.8;
				}
			}
			else
			{
				typeClass = "Luxury class";
				typeCar = "Jeep";
				price = budget * 0.9;
			}

            Console.WriteLine(typeClass);
            Console.WriteLine($"{typeCar} - {price:F2}");
        }
	}
}
