using aaaaaaaa;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace carpısmadenetimi
{
    public static class CollisionDetection
    {
        public static bool NoktaDikdörtgen (Nokta nokta, dikdortgen dikdörtgen)
        {
            if (nokta.X >= dikdörtgen.A.X + dikdörtgen.Boy &&
                nokta.Y >= dikdörtgen.A.Y + dikdörtgen.En)
            {
                return true;
            }
            return false;
        }
        public static bool NoktaCember(Nokta nokta, Cember cember)
        {
            if ((nokta.X - cember.M.X)* (nokta.X - cember.M.X) + (nokta.Y - cember.M.Y)* (nokta.Y - cember.M.Y)<=cember.Yarıcap*cember.Yarıcap)


            {
                return true;
            }
            return false;
        }
        public static bool DikdortgenDikdortgen(dikdortgen dikdortgen1, dikdortgen dikdortgen2)
        {
            Nokta merkez1 = new Nokta();
            Nokta merkez2 = new Nokta();
            merkez1.X = dikdortgen1.A.X + dikdortgen1.Boy / 2;
            merkez1.Y = dikdortgen1.A.Y + dikdortgen1.En / 2;
            merkez2.X = dikdortgen2.A.X + dikdortgen2.Boy / 2;
            merkez2.Y = dikdortgen2.A.Y + dikdortgen2.En / 2;
            if((merkez1.X-merkez2.X)<=(dikdortgen1.En / 2+ dikdortgen2.En / 2) && (merkez1.Y - merkez2.Y) <= (dikdortgen1.Boy / 2 + dikdortgen2.Boy / 2))



            {
                return true;
            }
            return false;
        }
        public static bool DikdortgenCember(dikdortgen dikdortgen, Cember cember)
        {
            double dx =cember.M.X- Math.Max(dikdortgen.A.X, Math.Min(dikdortgen.A.X, dikdortgen.Boy));
            double dy = cember.M.Y - Math.Max(dikdortgen.A.Y, Math.Min(dikdortgen.A.Y, dikdortgen.En));
            if ((dx*dx+dy*dy)<=(cember.Yarıcap*cember.Yarıcap))


            {
                return true;
            }
            return false;
        }
        public static bool CemberCember(Cember cember1, Cember cember2)
        {
            double dx = cember1.M.X - cember2.M.X;
            double dy = cember1.M.Y - cember2.M.Y;
            if ((dx * dx + dy * dy) <= (cember1.Yarıcap + cember2.Yarıcap))


            {
                return true;
            }
            return false;
        }
        public static bool NoktaKure(Nokta3d nokta, kure kure)
        {
            if 
                ((nokta.X<=kure.M.X+kure.Yarıcap) 
                && (nokta.X >= kure.M.X - kure.Yarıcap) 
                && (nokta.Y <= kure.M.Y + kure.Yarıcap) 
                && (nokta.Y >= kure.M.Y - kure.Yarıcap) 
                && (nokta.Z <= kure.M.Z + kure.Yarıcap) 
                && (nokta.Z >= kure.M.Z - kure.Yarıcap) )

            {
                return true;
            }
            return false;
        }
        public static bool NoktaDikdortgenPrizması(Nokta3d nokta, DikdortgenPrizması dikdortgenPrizması)
        {
            if
                ((nokta.X <= dikdortgenPrizması.A.X + dikdortgenPrizması.Boy)
                && (nokta.X >= dikdortgenPrizması.A.X - dikdortgenPrizması.Boy)
                && (nokta.Y <= dikdortgenPrizması.A.Y + dikdortgenPrizması.En)
                && (nokta.Y >= dikdortgenPrizması.A.Y - dikdortgenPrizması.En)
                && (nokta.Z <= dikdortgenPrizması.A.Z + dikdortgenPrizması.Derinlik)
                && (nokta.Z >= dikdortgenPrizması.A.Z - dikdortgenPrizması.Derinlik))

            {
                return true;
            }
            return false;
        }
        public static bool NoktaSilindir(Nokta3d nokta, Silindir silindir)
        {
            if
                ((nokta.X <= silindir.M.X + silindir.Yarıcap)
                && (nokta.X >= silindir.M.X - silindir.Yarıcap)
                && (nokta.Y <= silindir.M.Y + silindir.Yukseklik/2)
                && (nokta.Y >= silindir.M.Y - silindir.Yukseklik/2)
                && (nokta.Z <= silindir.M.Z + silindir.Yarıcap)
                && (nokta.Z >= silindir.M.Z - silindir.Yarıcap))

            {
                return true;
            }
            return false;
        }
        public static bool SilindirSilindir(Silindir silindir1, Silindir silindir2)
        {
            double uzaklık = (silindir1.M.X - silindir2.M.X) * (silindir1.M.X - silindir2.M.X)
                + (silindir1.M.Y - silindir2.M.Y) * (silindir1.M.Y - silindir2.M.Y);

            if ((uzaklık<=silindir1.Yarıcap+silindir2.Yarıcap) &&
                (silindir1.M.Z<=silindir2.M.Z+silindir2.Yukseklik) &&
                (silindir1.M.Z+silindir1.Yukseklik>=silindir2.M.Z))
            {
                return true;
            }
            return false;
        }
        public static bool KureKure(kure kure1, kure kure2)
        {

            double uzaklık = (kure1.M.X - kure2.M.X) * (kure1.M.X - kure2.M.X) *
                (kure1.M.Y - kure2.M.Y) * (kure1.M.Y - kure2.M.Y) *
                (kure1.M.Z - kure2.M.Z) * (kure1.M.Z - kure2.M.Z);

            if (uzaklık<=(kure1.Yarıcap+kure2.Yarıcap)* (kure1.Yarıcap + kure2.Yarıcap))


            {
                return true;
            }
            return false;
        }
        public static bool KureSilindir(kure kure, Silindir silindir)
        {

            double uzaklık = (double)Math.Sqrt(Math.Pow(kure.M.X - silindir.M.X, 2) + Math.Pow(kure.M.Y - silindir.M.Y, 2));

            if (uzaklık  <= silindir.Yarıcap + kure.Yarıcap && kure.M.Z >= silindir.M.Z && kure.M.Z <= silindir.M.Z + silindir.Yukseklik)


            {
                return true;
            }
            return false;
        }
        public static bool KureYüzey(kure kure, Yuzey yuzey)
        {

            double closestX = Math.Max(yuzey.A.X, Math.Min(yuzey.A.X, yuzey.A.X + yuzey.Boy));
            double closestY = Math.Max(yuzey.A.Y, Math.Min(yuzey.A.Y, yuzey.A.Y + yuzey.En));
            double closestZ = Math.Max(yuzey.A.Z, Math.Min(yuzey.A.Z, yuzey.A.Z + yuzey.Derinlik));

            double uzaklık = (double)Math.Sqrt(Math.Pow(kure.M.X - closestX, 2) + Math.Pow(kure.M.Y - closestY, 2) + Math.Pow(kure.M.Z - closestZ, 2));

            if (uzaklık <= kure.Yarıcap)


            {
                return true;
            }
            return false;
        }
        public static bool DikdörtgenprizmasıYüzey(DikdortgenPrizması prizma, Yuzey yuzey)
        {

            double closestX = Math.Max(yuzey.A.X, Math.Min(prizma.A.X, yuzey.A.X + yuzey.Boy));
            double closestY = Math.Max(yuzey.A.Y, Math.Min(prizma.A.Y, yuzey.A.Y + yuzey.En));
            double closestZ = Math.Max(yuzey.A.Z, Math.Min(prizma.A.Z, yuzey.A.Z + yuzey.Derinlik));

            double distanceX = closestX - prizma.A.X;
            double distanceY = closestY - prizma.A.Y;
            double distanceZ = closestZ - prizma.A.Z;

            double distance = (double)Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2) + Math.Pow(distanceZ, 2));

            if (distance <= prizma.Boy || distance <= prizma.En || distance <= prizma.Derinlik)


            {
                return true;
            }
            return false;
        }
        public static bool SilindirYüzey(Silindir silindir, Yuzey yuzey)
        {

            double closestX = Math.Max(yuzey.A.X, Math.Min(silindir.M.X, yuzey.A.X + yuzey.Boy));
            double closestY = Math.Max(yuzey.A.Y, Math.Min(silindir.M.Y, yuzey.A.Y + yuzey.En));
            double closestZ = Math.Max(yuzey.A.Z, Math.Min(silindir.M.Z, yuzey.A.Z + yuzey.Derinlik));

            double distance = (double)Math.Sqrt(Math.Pow(silindir.M.X - closestX, 2) + Math.Pow(silindir.M.Y - closestY, 2));

            if (distance <= silindir.Yarıcap && closestZ <= silindir.M.Z + silindir.Yukseklik && closestZ >= silindir.M.Z)

            {
                return true;
            }
            return false;
        }
        public static bool DikdörtgenprizmasıKüre(DikdortgenPrizması prizma, kure kure)
        {

            double closestX = Math.Max(prizma.A.X, Math.Min(kure.M.X, prizma.A.X + prizma.Boy));
            double closestY = Math.Max(prizma.A.X, Math.Min(kure.M.Y, prizma.A.Y + prizma.En));
            double closestZ = Math.Max(prizma.A.X, Math.Min(kure.M.Z, prizma.A.Z + prizma.Derinlik));

            double distanceX = kure.M.X - closestX;
            double distanceY = kure.M.Y - closestY;
            double distanceZ = kure.M.Z - closestZ;
            
            double distance = (double)Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2) + Math.Pow(distanceZ, 2));

            if (distance <= kure.Yarıcap || (closestX == prizma.A.X || closestX == prizma.A.X + prizma.Boy) && distanceY <= kure.Yarıcap && 
                distanceZ <= kure.Yarıcap || (closestY == prizma.A.Y || closestY == prizma.A.Y + prizma.En) && distanceX <= kure.Yarıcap && distanceZ <= kure.Yarıcap ||
                (closestZ == prizma.A.Z || closestZ == prizma.A.Z + prizma.Derinlik) && distanceX <= kure.Yarıcap && distanceY <= kure.Yarıcap)


            {
                return true;
            }
            return false;
        }
        public static bool DikdörtgenprizmasıDikdörtgenprizması(DikdortgenPrizması prizma1, DikdortgenPrizması prizma2)
        
        {
            if (prizma1.A.X <= prizma2.A.X+prizma2.Boy &&
            prizma1.A.X + prizma1.Boy >= prizma2.A.X &&
            prizma1.A.Y <= prizma2.A.Y+prizma2.En &&
            prizma1.A.Y + prizma1.En >= prizma2.A.Y &&
            prizma1.A.Z <= prizma2.A.Z+ prizma2.Derinlik &&
            prizma1.A.Z + prizma1.Derinlik >= prizma2.A.Z)


            {
                return true;
            }
            return false;
        }

    }


}
