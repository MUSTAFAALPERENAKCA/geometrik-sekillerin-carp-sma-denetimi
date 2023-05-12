using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpısmadenetimi
{
    public class Nokta
    {
        int x; int y;
        public Nokta()
        {
            Random random = new Random();
            X = random.Next(-10,10);
            Y = random.Next(-10, 10);
        }
        public Nokta(   int x, int y)
        { X = x; Y = y; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
}
