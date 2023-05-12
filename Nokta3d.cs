using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpısmadenetimi
{
    public class Nokta3d
    {
        int x; int y; int z;
        public Nokta3d()
        {
            Random random = new Random();
            X = random.Next(-10, 10);
            Y = random.Next(-10, 10);
            Z = random.Next(-10, 10);
        }
        public Nokta3d(int x, int y)
        { X = x; Y = y; Z = z; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }
    }
}
