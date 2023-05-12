using aaaaaaaa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpısmadenetimi
{
    public class dikdortgen
    {
        Nokta a; int en; int boy;
        public dikdortgen()
        {
            Random random = new Random();  
            A=new Nokta();
            En= random.Next(1, 10);
            Boy = random.Next(1, 10);
        }
        public dikdortgen(Nokta a, int x,int y)
        { A = a; En = en;Boy = boy; }
        public int En { get => en; set => en = value; }
        public int Boy { get => boy; set => boy = value; }
        internal Nokta A { get => a; set => a = value; }
    }
}
