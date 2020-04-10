using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public string Type { get; set; }
    public string Name { get; set; }
    public int Damage { get; set; }
    public int Block { get; set; }

    public int EnergyCost { get; set; }

    public Card(string type, string name, int damage, int block, int energyCost)
    {
        Type = type;
        Name = name;
        Damage = damage;
        Block = block;
        EnergyCost = energyCost;
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
