using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_3
{
    delegate int Op(int d1, int d2);
    
    class Program
    {
        public static int Mul(int m1, int m2)
        {
            return m1*m2;
        }

        public static int Plus(int p1, int p2)
        {
            return p1+p2;
        }

        public static int Less(int l1, int l2)
        {
            return l1-l2;
        }

        public static int Result(int x, int y, Op tv)
        {
            int re = tv(x, y);
            return re;
        }

        static void Main(string[] args)
        {
            int ten = 10, three = 3,two=2,five=5,temp,temp1,temp2;
            Console.WriteLine("{0}+{1}*{2}-{3}\n", ten, three, two, five);

            Op o;
            o = new Op(Mul);
            temp = Result(three, two, o);
            Console.WriteLine("{0}+{1}-{2}\n",ten,temp,five);

            Op o1;
            o1 = new Op(Plus);
            temp1 = Result(ten,temp, o1);
            Console.WriteLine("{0}-{1}\n",temp1, five);

            Op o2;
            o2 = new Op(Less);
            temp2 = Result(temp1,five, o2);
            Console.WriteLine("{0}\n", temp2);

            Console.Read();
        }
    }
}
