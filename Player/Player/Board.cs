using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Board
    {
        private int G1,G2,G3;
         public void PickBall(int group, int balls)
        {
            if (group == 1)
                G1 -= balls;
            else if (group ==2)
                G2-=balls;
            else if (group ==3)
                G3-=balls;
               
        }

        public  void PrintGame()
         {
            Console.Write("Group 1:");
                for(int i=0;i<G1;i++)
                {
                    Console.Write("O ");
                }
            Console.WriteLine(" ");

            Console.Write("Group 2:");
                for(int i=0;i<G2;i++)
                {
                    Console.Write("O ");
                }
            Console.WriteLine(" ");

            Console.Write("Group 3:");
                for(int i=0;i<G3;i++)
                {
                    Console.Write("O ");
                }
            Console.WriteLine(" ");
         }

        public bool IsGameOver()
        {
            if (G1 == 0 && G2 == 0 && G3 == 0)
            {
                return true;
            }
            return false;
        }

        public Board(int g1,int g2,int g3)
        {
            this.G1 = g1;
            this.G2 = g2;
            this.G3 = g3;
        }
    }
}
