using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class Fighter
    {

        int hp = 20;
        public string name;
        static Random rand = new Random();


        public int Attack()
        {
            return rand.Next(2,4);
        }
        public void Hurt(int amount)
        {

            hp -= amount;

        }
        public bool IsAlive()
        {

            return hp > 0;

        }
        public int GetHp()
        {
            return hp;
        }
    }
}
