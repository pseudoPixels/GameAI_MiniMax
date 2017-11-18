using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanPlayer : MonoBehaviour, IBasePlayer
{
    private GameManager gameManager;
    private bool isMyTurn = false;
    private GameState currentGameState;

    private string playSymbol = "X";



    public HumanPlayer(GameManager gM)
    {
        this.gameManager = gM;
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
        this.currentGameState = currentState;
    }

    public void setCurrentGameState(GameState gS)
    {
        throw new NotImplementedException();
    }

    public void setTurn(bool isTurn)
    {
        this.isMyTurn = isTurn;
    }

    public void playMove(int posIndex)
    {
        if(this.currentGameState.isValidMove(posIndex) == true)
        {
            string[] newBoard = this.currentGameState.getGameBoard();
            newBoard[posIndex] = this.getPlaySymbol();

            this.gameManager.onTurnPlayed(this.getPlaySymbol(), posIndex, newBoard);
        }
    }


}
