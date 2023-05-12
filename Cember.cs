using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpısmadenetimi
{
    public class Cember
    {
        Nokta m; int yarıcap;
        public Cember()
        {
            Random random = new Random();
            M = new Nokta();// merkez noktası
            Yarıcap = random.Next(1, 10);
        }
        public Cember (Nokta p, int r)
        { M = p; Yarıcap = r; }
        public int Yarıcap { get => yarıcap; set => yarıcap = value; }
        internal Nokta M { get => m; set => m = value; }
    }
}
