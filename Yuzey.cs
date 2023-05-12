using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpısmadenetimi
{
    public class Yuzey
    {
        Nokta3d m; int en; int boy; int derinlik;
        public Yuzey()
        {
            Random random = new Random();
            A = new Nokta3d();// merkez noktası
            En = 1;
            Boy = random.Next(1, 10);
            Derinlik = random.Next(1, 10);
        }
        public Yuzey(Nokta3d p, int en, int boy)
        { A = p; En = en; Boy = boy; }
        public int En { get => en; set => en = value; }
        public int Derinlik { get => derinlik; set => derinlik = value; }

        public int Boy { get => boy; set => boy = value; }
        internal Nokta3d A { get => m; set => m = value; }
    }
}
