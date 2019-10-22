using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Controller
    {
        private Board Game;
        private Player p1, p2;
       
        public Controller()
        {
            this.Game = new Board(3, 5, 7);
            this.p1 = new Player("Nhân");
            this.p2 = new Player("Alexandra Wut");
        }
        public void PlayGame()
        {
            Game.PrintGame();
            while(true)
            {
                Console.WriteLine("Turn of "+p1.GetName());
                p1.PickBall(Game);
                Game.PrintGame();
                if(Game.IsGameOver())
                {
                    Console.WriteLine("Player 1 Lose!!");
                    break;
                }
                Console.WriteLine("It's turn"+p2.GetName());
                p2.PickBall(Game);
                Game.PrintGame();
                if (Game.IsGameOver())
                {
                    Console.WriteLine("Player 2 Lose!!");
                    break;
                }
            }
        }
    }
}
