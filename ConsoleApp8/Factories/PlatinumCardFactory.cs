using ConsoleApp8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Factories
{
    internal class PlatinumCardFactory : CardFactory
    {

        private readonly decimal _price;
        private readonly string _description;

        public PlatinumCardFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override ICard GetCard()
        {
            PlatinumCard silverCard = new(_price)
            {
                Description = _description,
            };
            return silverCard;
        }
    }
}