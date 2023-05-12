using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpısmadenetimi
{
    public class Silindir
    {
        Nokta3d m; int yarıcap; int yükseklik;
        public Silindir()
        {
            Random random = new Random();
            M = new Nokta3d();// merkez noktası
            Yarıcap = random.Next(1, 10);
            Yukseklik = random.Next(1, 10);
        }
        public Silindir(Nokta3d p, int r)
        { M = p; Yarıcap = yarıcap; }
        public int Yarıcap { get => yarıcap; set => yarıcap = value; }
        public int Yukseklik { get => yükseklik; set => yükseklik = value; }
        internal Nokta3d M { get => m; set => m = value; }

    }
}
