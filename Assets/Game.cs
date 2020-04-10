using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    //Player cards
    Card card1 = new Card("Attack", "Blade", 5, 0, 1);
    Card card2 = new Card("Attack", "Whirlwind", 9, 0, 2);
    Card card3 = new Card("Defense", "Shield Block", 0, 5, 1);
    Card card4 = new Card("Defense", "Shield Bash", 0, 9, 2);

    List<Card> playerDeckList = new List<Card>();
   
    //Monster cards
    Card m1 = new Card("Attack", "Monster Attack 1", 4, 0, 1);
    Card m2 = new Card("Defense", "Monster defense 1", 0, 5, 1);
    private Unit Player;
    private Unit Monster;
    List<Card> monsterDeckList = new List<Card>();

    void Start()
    {
        playerDeckList.Add(card1); playerDeckList.Add(card2); playerDeckList.Add(card3); playerDeckList.Add(card4);
        Deck playerDeck = new Deck(playerDeckList);

        monsterDeckList.Add(m1); monsterDeckList.Add(m2);
        Deck monsterDeck = new Deck(monsterDeckList);

        Player = new Unit(100, 4, playerDeck, "Player");
        Monster = new Unit(35, 1, monsterDeck, "AI");


    }

    // Update is called once per frame
    void Update()
    {
        Text text = GameObject.Find("PlayerHp").GetComponent<Text>();
        text.text = "Health = " + Player.Health;

        playTurn();
    }

    void playTurn()
    {
       bool whosTurn = gameObject.GetComponent<TurnManager>().playerTurn;

    }


}
