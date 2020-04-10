using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{

    public int turn = 0;
    public bool playerTurn = true;

    public Button endTurn;

    void Start()
    {
        endTurn.onClick.AddListener(HandleTurn);
    }
   
    public void HandleTurn()
    {
        playerTurn = false;
        turn++;
        Debug.Log("Hello?");


    }

    public int Test()
    {
        return 0;
    }
}
