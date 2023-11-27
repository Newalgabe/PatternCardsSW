using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Model
{
    internal class PlatinumCard : ICard
    {
        private readonly string _name;
        private readonly decimal _price;

        public PlatinumCard(decimal price)
        {
            _name = "Platinum Card";
            _price = price;
        }

        public string Name => _name;
        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }
}
