using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    class Sinh_vien
    {
        int MSV;
        string HoTen;
        float diemLT, diemTH;

        //get set
        public int MSV1
        {
            get { return MSV; }
            set { MSV = value; }
        }
        public string HoTen1
        {
            get { return HoTen; }
            set { HoTen = value; }
        }
        public float DiemLT
        {
            get { return diemLT; }
            set { diemLT = value; }
        }
        public float DiemTH
        {
            get { return diemTH; }
            set { diemTH = value; }
        }


        //end get set

        public Sinh_vien()
        {
            MSV = 0;
            HoTen = "";
            diemLT = 0;
            diemTH = 0;
        }

        public Sinh_vien(int MSV, string HoTen, float diemLT, float diemTH)
        {
            this.MSV = MSV;
            this.HoTen = HoTen;
            this.diemLT = diemLT;
            this.diemTH = diemTH;
        }

        public void nhapSV()
        {
            do
            {
                Console.Write("nhap MSV: ");
                MSV = int.Parse(Console.ReadLine());
                Console.Write("nhap ho ten SV: ");
                HoTen = Console.ReadLine();
                Console.Write("nhap diem LT: ");
                diemLT = float.Parse(Console.ReadLine());
                Console.Write("nhap diem TH: ");
                diemTH = float.Parse(Console.ReadLine());
                Console.WriteLine("");
            } while (MSV < 0 || diemLT < 0 || diemLT > 10 || diemTH < 0 || diemTH > 10 || HoTen == null);
        }

        public float diemTB(float diemLT, float diemTH)
        {
            return (diemLT + diemTH) / 2;
        }

        public void xuatSV()
        {
            Console.WriteLine("MSV: {0}", MSV);
            Console.WriteLine("Ho Ten: {0}", HoTen);
            Console.WriteLine("diem LT: {0}", diemLT);
            Console.WriteLine("diem TH: {0}", diemTH);
            Console.WriteLine("DTB: {0}", diemTB(diemLT, diemTH));
            Console.ReadKey();
        }
    }
}
