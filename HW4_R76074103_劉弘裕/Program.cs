using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_R76074103_劉弘裕
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputclass, exit;
            CDplayer CD;
            DVDplayer DVD;
            Poly po;
            while (true)
            {
                Console.Write("請輸入放入的光碟 (CD 或 DVD) : ");
                inputclass = Console.ReadLine();
                if (inputclass == "CD" || inputclass == "cd")
                {
                    CD = new CDplayer();
                    po = new Poly(CD);

                }
                else if (inputclass == "DVD" || inputclass == "dvd")
                {
                    DVD= new DVDplayer();
                    po = new Poly(DVD);
                }
                else
                {
                    Console.Write("要結束時，請按 q 或 Q 離開…\n");
                    exit = Console.ReadLine();
                    if (exit == "q" || exit == "Q")
                    {
                        break;
                    }

                }

            }
        }
    }

    class player
    {
        public virtual void say()
        {
            
        }
    }

    class CDplayer:player
    {
        public override void say()
        {
            Console.Write("現在播放的是 音樂CD\n");
        }
    }

    class DVDplayer:player
    {
        public override void say()
        {
            Console.Write("現在播放的是 影片DVD\n");
        }

    }

    class Poly
    {
        public Poly(player p)
        {
            p.say();
        }
    }

}
