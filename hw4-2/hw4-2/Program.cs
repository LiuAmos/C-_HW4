using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string num;
            double l,w;
            while (true)
            {
                Console.Write("請選擇形狀（1.三角形 2.矩形 3.菱形 4.平行四邊形 0.離開）\n");
                num = Console.ReadLine();

                if (num == "0")
                {
                    break;
                }

                switch (num)
                {
                    case "1":
                        Console.Write("請輸入 高  ");
                        l= double.Parse(Console.ReadLine());
                        Console.Write("請輸入 底  ");
                        w= double.Parse(Console.ReadLine());
                        Tri tr = new Tri();
                        double area1 = tr.Lenwei(l, w);
                        Console.Write("三角形： 高 = {0}，底 = {1}，面積為 {2}\n",l,w,area1);
                        break;

                    case "2":
                        Console.Write("請輸入 高  ");
                        l = double.Parse(Console.ReadLine());
                        Console.Write("請輸入 底  ");
                        w = double.Parse(Console.ReadLine());
                        Rect re = new Rect();
                        double area2 = re.Lenwei(l, w);
                        Console.Write("矩形： 高 = {0}，底 = {1}，面積為 {2}\n", l, w, area2);
                        break;

                    case "3":
                        Console.Write("請輸入 高  ");
                        l = double.Parse(Console.ReadLine());
                        Console.Write("請輸入 底  ");
                        w = double.Parse(Console.ReadLine());
                        Dia di = new Dia();
                        double area3 = di.Lenwei(l, w);
                        Console.Write("菱形： 高 = {0}，底 = {1}，面積為 {2}\n", l, w, area3);
                        break;

                    case "4":
                        Console.Write("請輸入 高  ");
                        l = double.Parse(Console.ReadLine());
                        Console.Write("請輸入 底  ");
                        w = double.Parse(Console.ReadLine());
                        Para pa = new Para();
                        double area4 = pa.Lenwei(l, w);
                        Console.Write("平行四邊形： 高 = {0}，底 = {1}，面積為 {2}\n", l, w, area4);
                        break;
                    default:
                        Console.Write("輸入錯誤\n");
                        break;


                }

            }
        }
    }

    interface ILenwei
    {
        
        double Lenwei(double a,double b);
    }

    class Tri: ILenwei
    {
        public double Lenwei(double len, double wei)
        {
            return 0.5* len* wei;
        }
    }

    class Rect : ILenwei
    {
        public double Lenwei(double len, double wei)
        {
            return len * wei;
        }
    }

    class Dia : ILenwei
    {
        public double Lenwei(double len, double wei)
        {
            return len * wei;
        }
    }

    class Para : ILenwei
    {
        public double Lenwei(double len, double wei)
        {
            return len * wei;
        }
    }
}
