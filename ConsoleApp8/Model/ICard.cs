using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Model
{
    internal interface ICard
    {
        string Name { get; }
        string Description { get; }
        decimal GetPrice();
    }
}
