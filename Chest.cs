using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_JuanHernandez
{
    internal class Chest : IOpen
    {
        public void Open()
        {
            Console.WriteLine($"Chest opens to {IOpen._maxRotation} degrees");
        }
    }
}
