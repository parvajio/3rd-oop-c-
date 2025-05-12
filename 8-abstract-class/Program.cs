using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Hero h1 = new Hero("suri", "hero");
            Boss b = new Boss("bonduk", 45);
            b.hp = 300;
            b.useAttack(b);
        }
    }

    abstract class Character{
        public string name;
        public int xp;
        public int hp;

        public abstract void useAttack(Boss b);
    }

    class Hero: Character{
        public string weapon;
        public string role;

        public Hero(string weapon, string role):base(){
            this.weapon = weapon;
            this.role = role;
        }

        public override void useAttack(Boss b)
        {
            Console.WriteLine($"used {this.weapon} to attack");
        }
    }

    class Boss:Character {
        public string weapon;
        public int attack;

        public Boss(string weapon, int attack):base(){
            this.weapon = weapon;
            this.attack = attack;
        }

        public override void useAttack(Boss b){
            int damage = 100;
            while(b.hp > 0){
                Console.WriteLine($"{b.hp}");
                hp -= damage;
            }
            Console.WriteLine($"{b.name} os defeated");
        }
    }
}