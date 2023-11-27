using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Model
{
    internal class GoldCard : ICard
    {
        private readonly string _name;
        private readonly decimal _price;

        public GoldCard(decimal price)
        {
            _name = "Gold Card";
            _price = price;
        }

        public string Name => _name;
        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }
}
