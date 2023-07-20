using System;

namespace _02._Bike_Race
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int juniorCyclists = int.Parse(Console.ReadLine());
			int seniorCyclists = int.Parse(Console.ReadLine());
			string trackType = Console.ReadLine();

			double moneyJunior = 0;
			double moneySenior = 0;

			switch (trackType)
			{
				case "trail":
					moneyJunior = juniorCyclists * 5.50;
					moneySenior = seniorCyclists * 7.00;
					break;
				case "cross-country":
					moneyJunior = juniorCyclists * 8.00;
					moneySenior = seniorCyclists * 9.50;
					break;
				case "downhill":
					moneyJunior = juniorCyclists * 12.25;
					moneySenior = seniorCyclists * 13.75;
					break;
				case "road":
					moneyJunior = juniorCyclists * 20.00;
					moneySenior = seniorCyclists * 21.50;
					break;
			}

			double total = moneyJunior + moneySenior;

			if (juniorCyclists + seniorCyclists >= 50 && trackType == "cross-country")
			{
				total = total - total * 0.25;
			}

			total = total - total * 0.05;

			Console.WriteLine($"{total:F2}");
		}
	}	
}
