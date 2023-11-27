using ConsoleApp8.Factories;
using ConsoleApp8.Model;
using Microsoft.VisualBasic;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Silver, 2 - Gold, 3 - Platinum");

            string CardType = Console.ReadLine();

            CardFactory CardFactory = GetFactory(CardType);
            ICard card = CardFactory.GetCard();

            Console.WriteLine(
                $"Name: {card.Name}\n" +
                $"Description: {card.Description}\n" +
                $"Price: {card.GetPrice()}\n"
                );
        }

        private static CardFactory GetFactory(string cardType)
        {
            if (cardType == "1") 
            {
                return new SilverCardFactory(20, "Noob");
            }
            else if (cardType == "2")
            {
                return new GoldCardFactory(40, "W");
            }
            else if (cardType == "3")
            {
                return new PlatinumCardFactory(80, "GG");
            }
            return null;
        }
    }
}