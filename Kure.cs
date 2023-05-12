using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpısmadenetimi
{
    public class kure
    {
        Nokta3d m; int yarıcap;
        public kure()
        {
            Random random = new Random();
            M = new Nokta3d();// merkez noktası
            Yarıcap = random.Next(1, 10);
        }
        public kure(Nokta3d p, int r)
        { M = p; Yarıcap = r; }
        public int Yarıcap { get => yarıcap; set => yarıcap = value; }
        internal Nokta3d M { get => m; set => m = value; }
    }

}
