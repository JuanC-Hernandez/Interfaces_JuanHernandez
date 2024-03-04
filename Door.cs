using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_JuanHernandez
{
    internal class Door : IOpen, IClose
    {
        public void Close()
        {
            Console.WriteLine($"Door Closes to {IOpen._minRotation} degrees");
        }

        public void Open()
        {
            Console.WriteLine($"Door opens to {IOpen._maxRotation} degrees");
        }
    }
}
