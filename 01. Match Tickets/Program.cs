using System;

namespace _01._Match_Tickets
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double budget = double.Parse(Console.ReadLine());
			string ticketType = Console.ReadLine();
			int countOfPeople = int.Parse(Console.ReadLine());
			double price = 0;
			double transportFee = 0;

			switch (ticketType)
			{
				case "VIP": price = 499.99; break;
				case "Normal": price = 249.99; break;
			}

			if (countOfPeople >= 1 && countOfPeople <= 4)
			{
				transportFee = budget * 0.75;
			}
			else if (countOfPeople >= 5 && countOfPeople <= 9)
			{
				transportFee = budget * 0.6;
			}
			else if (countOfPeople >= 10 && countOfPeople <= 24)
			{
				transportFee = budget * 0.5;
			}
			else if (countOfPeople >= 25 && countOfPeople <= 49)
			{
				transportFee = budget * 0.4;
			}
			else
			{
				transportFee = budget * 0.25;
			}

			double total = transportFee + countOfPeople * price;

			if (budget >= total)
			{
				double leftMoney = budget - total;
				Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
			}
			else
			{
				double needMoney = total - budget;
				Console.WriteLine($"Not enough money! You need {needMoney:F2} leva.");
			}
		}
	}
}
