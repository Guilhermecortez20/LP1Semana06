using System;

namespace MyGame
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }


        public Enemy(string name, int health)
        {
            Name = name;
            Health = health;
        }

   
        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
                Health = 0;  
        }

        public void Heal(int amount)
        {
            Health += amount;
        }

        private bool IsLowHealth()
        {
            return Health <= 20;  
        }

        private void Attack()
        {
            if (IsLowHealth())
            {
                Console.WriteLine($"{Name} está com pouca saúde, atacando com força reduzida!");
            }
            else
            {
                Console.WriteLine($"{Name} ataca com força total!");
            }
        }
    }
}
