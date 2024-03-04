using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_JuanHernandez
{
    internal class Bottle : IOpen
    {
        public void Open()
        {
            Console.WriteLine($"Bottle opens to {IOpen._maxRotation} degrees");
        }
    }
}
