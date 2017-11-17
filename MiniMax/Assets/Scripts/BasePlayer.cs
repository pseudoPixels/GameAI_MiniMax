using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePlayer  {
    GameState currentState;
    GameManager gameManager;

    private bool isItMyTurn = false;

    public BasePlayer(GameManager gM)
    {
        this.gameManager = gM;
    }

    public void setCurrentGameState(GameState gS)
    {
        this.currentState = gS;
    }

    public abstract void onGettingPlayTurn(GameState currentState);

}
