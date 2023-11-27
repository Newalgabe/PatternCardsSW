using ConsoleApp8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Factories
{
    internal abstract class CardFactory
    {
        public abstract ICard GetCard();
    }
}
