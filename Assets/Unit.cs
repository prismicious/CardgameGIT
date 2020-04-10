using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public int Health { get; set; }
    public int Energy { get; set; }

    public string Type { get; set; }

    public Deck PlayerDeck { get; set; }

    public int Shield { get; set; }

    public Unit(int health, int energy, Deck deck, string type)
    {
        Health = health;
        Energy = energy;
        PlayerDeck = deck;
        Type = type;
    }

    public int UnitAttack(int damage, int enemyHp, int enemyShield)
    {
        if (enemyShield == 0)
        enemyHp = enemyHp - damage;

        else
        {
            enemyHp = (enemyHp + enemyShield) - damage;
        }

        return enemyHp;
    }

    public int UnitShield(int shield)
    {
        Shield = Shield + shield;
        return Shield;
    }
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
