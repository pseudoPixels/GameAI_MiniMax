using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    GameState gameState;

	// Use this for initialization
	void Start () {
        gameState = new GameState();
	}
	
    public void onTurnPlayed(string[] newBoard)
    {

    }


}
