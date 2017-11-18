using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState {

    private string[] gameBoard; 
    private string turn = "";//AI or HumanPlayer

    public GameState()
    {
        //empty board
        this.gameBoard = new string[] { "E", "E", "E",
                                   "E", "E", "E",
                                   "E", "E", "E"
                                  };
    }


    public GameState(string gameTurn)
    {
        //empty board
        this.gameBoard = new string[] { "E", "E", "E",
                                   "E", "E", "E",
                                   "E", "E", "E"
                                  };
        this.turn = gameTurn;

    }


    public GameState(string gameTurn, string[] board)
    {
        this.turn = gameTurn;
        this.gameBoard = board;
    }

    public string[] getGameBoard()
    {
        return gameBoard;
    }

    public void setGameBoard(string[] newBoard)
    {
        this.gameBoard = newBoard;
    }

    public void resetBoard()
    {
        //empty board
        this.gameBoard = new string[] { "E", "E", "E",
                                   "E", "E", "E",
                                   "E", "E", "E"
                                  };
    }

    public bool isBoardFull()
    {
        for(int i = 0; i < this.gameBoard.Length; i++)
        {
            if (this.gameBoard[i] == "E") return false;
        }

        return true;
    }

    public bool isWinningState()
    {
        return false;
    }

    public string getWinner()
    {
        return null;
    }

    //either board is full or someone has won
    public bool isTerminalState()
    {
        return false;
    }

    public List<int> getEmptySpaces()
    {
        List<int> emptySapces = new List<int>();

        for(int i=0; i<this.gameBoard.Length; i++)
        {
            if (this.gameBoard[i] == "E") emptySapces.Add(i);
        }

        return emptySapces;
    }

    public bool isValidMove(int posIndex)
    {
        if (this.gameBoard[posIndex] == "E") return true;

        return false;
    }




}
