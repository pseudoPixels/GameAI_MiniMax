using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPlayer : MonoBehaviour, IBasePlayer
{
    private GameManager gameManager;
    private bool isMyTurn = false;

    private string playSymbol = "O";

    private int aiDifficulty = 0;

    public AIPlayer(GameManager gM)
    {
        this.gameManager = gM;
    }

    public void setAIDifficulty(int diff)
    {
        this.aiDifficulty = diff;
    }

    public int getAIDifficulty()
    {
        return this.aiDifficulty;
    }

    public string getPlaySymbol()
    {
        return playSymbol;
    }

    public bool isItMyTurn()
    {
        return isMyTurn;
    }

    public void onGettingPlayTurn(GameState currentState)
    {
        this.setTurn(true);

        if (this.aiDifficulty <= 30) playDumb(currentState);
    }

    private void playDumb(GameState currentState)
    {
        List<int> emptyBoradSpaces = currentState.getEmptySpaces();
        string[] currentBoard = currentState.getGameBoard();

        int randPos = UnityEngine.Random.Range(0, emptyBoradSpaces.Count);

        randPos = emptyBoradSpaces[randPos];
        currentBoard[randPos] = getPlaySymbol();

        this.gameManager.onTurnPlayed(getPlaySymbol(), randPos, currentBoard);

    }



    public void setCurrentGameState(GameState gS)
    {
        throw new NotImplementedException();
    }

    public void setTurn(bool isTurn)
    {
        this.isMyTurn = isTurn;
    }
}
