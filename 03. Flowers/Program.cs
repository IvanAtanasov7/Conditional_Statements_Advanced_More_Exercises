using System;

namespace _03._Flowers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int chrysanthemums = int.Parse(Console.ReadLine());
			int roses = int.Parse(Console.ReadLine());
			int tulips = int.Parse(Console.ReadLine());
			string season = Console.ReadLine();
			string holiday = Console.ReadLine();

			double priceChrysanthemums = 0;
			double priceRoses = 0;
			double priceTulips = 0;

			if (season == "Spring" || season == "Summer")
			{
				priceChrysanthemums = 2.00;
				priceRoses = 4.10;
				priceTulips = 2.50;
			}
			else if (season == "Autumn" || season == "Winter")
			{
				priceChrysanthemums = 3.75;
				priceRoses = 4.50;
				priceTulips = 4.15;
			}

			double total = chrysanthemums * priceChrysanthemums + roses * priceRoses + tulips * priceTulips;

			if (holiday == "Y")
			{
				total = total + total * 0.15;
			}
            
            if (tulips > 7 && season == "Spring")
			{
				total = total - total * 0.05;
			}
			if (roses >= 10 && season == "Winter")
			{
				total = total - total * 0.1;
			}
			if (chrysanthemums + roses + tulips > 20)
			{
				total = total - total * 0.2;
			}

			double totalPrice = total + 2;

            Console.WriteLine($"{totalPrice:F2}");
        }
	}
}
