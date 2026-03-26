using System;
using System.Collections.Generic;

public class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }

    public static string[] DefaultNames = {
        "Goblin", "Orc", "Troll", "Skeleton",
        "Dark Knight", "Bandit", "Wolf"
    };

    public Enemy(string name, int health, int attack)
    {
        Name = name;
        Health = health;
        Attack = attack;
    }

    public static Enemy GenerateRandomEnemy(int seed)
    {
        Random rnd = new Random(seed);

        string name = DefaultNames[rnd.Next(DefaultNames.Length)];
        int health = rnd.Next(50, 100);
        int attack = rnd.Next(5, 20);

        return new Enemy(name, health, attack);
    }
}