using System;

namespace _05._Vacation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double budget = double.Parse(Console.ReadLine());
			string season = Console.ReadLine();
			string location = "";
			string placesToStay = "";
			double price = 0;

			if (budget <= 1000)
			{
				placesToStay = "Camp";

				if (season == "Summer")
				{
					location = "Alaska";
					price = budget * 0.65;
				}
				else if (season == "Winter")
				{
					location = "Morocco";
					price = budget * 0.45;
				}
            }
			else if (budget > 1000 && budget <= 3000)
			{
				placesToStay = "Hut";

				if (season == "Summer")
				{
					location = "Alaska";
					price = budget * 0.8;
				}
				else if (season == "Winter")
				{
					location = "Morocco";
					price = budget * 0.6;
				}
			}
			else
			{
				placesToStay = "Hotel";
				if (season == "Summer")
				{
					location = "Alaska";
					price = budget * 0.9;
				}
				else if (season == "Winter")
				{
					location = "Morocco";
					price = budget * 0.9;
				}
			}
            Console.WriteLine($"{location} - {placesToStay} - {price:F2}");
        }
	}
}
