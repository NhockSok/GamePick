using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Player
    {
        private string Name;

        public void PickBall(Board Game)
        {
            Console.Write("Which group do you choose: ");
            int group =int.Parse(Console.ReadLine());

            Console.Write("How many balls do you pick: ");
            int balls = int.Parse(Console.ReadLine());

            Game.PickBall(group, balls);
        }
        
        public Player(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }
    }
}
