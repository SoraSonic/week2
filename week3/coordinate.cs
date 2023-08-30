using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    class Coordinate
    {
        float x;
        float y;
        string TenTD;
        //get set
        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public string TenTD1
        {
            get { return TenTD; }
            set { TenTD = value; }
        }
        //end get set

        public Coordinate(float x,float y, string TenTD) {
            this.x = x;
            this.y = y;
            this.TenTD = TenTD;
        }
        public Coordinate() {
            float x = 0;
            float y = 0;
            string TenTD = "" ;
        }
        public void Nhap() {
            Console.WriteLine("Ten toa do:");
            TenTD = Console.ReadLine();
            Console.WriteLine("Toa do X:");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Toa do Y:");
            y = float.Parse(Console.ReadLine());
        }
        public void Xuat() {
            Console.WriteLine("Ten toa do: {0} \nX: {1} \nY: {2} \n",TenTD, x, y);
        }
    }
}
