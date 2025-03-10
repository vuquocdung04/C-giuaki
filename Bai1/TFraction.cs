using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class TFraction
    {
        int tuSo;
        int mauSo;

        public TFraction(int tu = 0, int mau = 1)
        {
            if (mau == 0) Console.WriteLine("Mau so khong bang 0");
            this.tuSo = tu;
            this.mauSo = mau;
            RutGon();
        }

        public void Input()
        {
            Console.Write("Nhap tu so: ");
            tuSo = int.Parse(Console.ReadLine());

            Console.Write("Nhap mau so: ");
            
            mauSo = int.Parse(Console.ReadLine());

            if (this.mauSo == 0) Console.WriteLine("Mau so khong the bang 0");

            RutGon();
        }

        public void HienThi()
        {
            Console.WriteLine(tuSo + "/" + mauSo );
        }

        public void RutGon()
        {
            int gcd = GCD(Math.Abs(tuSo), Math.Abs(mauSo));
            tuSo /= gcd;
            mauSo /= gcd;
            
            if(tuSo < 0)
            {
                tuSo = -tuSo;
                mauSo = -mauSo;
            }
        }

        int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);

        //nap chong toan tu



    }
}
