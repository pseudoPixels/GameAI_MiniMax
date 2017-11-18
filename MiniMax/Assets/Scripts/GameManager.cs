using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    //references
    GameState gameState;
    HumanPlayer humanPlayer;
    AIPlayer aiPlayer;

    public Button[] ticTacToeButtons;

   

	void Start () {
        gameState = new GameState();
        humanPlayer = new HumanPlayer(this);
        aiPlayer = new AIPlayer(this);

        //giving the play turn to aiPlayer
        aiPlayer.onGettingPlayTurn(this.gameState);

    }
	
    public void onTurnPlayed(string playedSymbol, int posIndex, string[] newBoard)
    {
        this.gameState.setGameBoard(newBoard);//update the state board

        if (aiPlayer.isItMyTurn())
        {
            aiPlayer.setTurn(false); // remove the turn first of all

            //update the GUI
            ticTacToeButtons[posIndex].GetComponentInChildren<Text>().text = aiPlayer.getPlaySymbol();
            
            //still to spaces available to play... give the turn to human player
            if(gameState.isBoardFull() == false)
            {
                humanPlayer.onGettingPlayTurn(this.gameState);
            }

        }
        else//human player played the move
        {
            humanPlayer.setTurn(false); //take away the turn first
            ticTacToeButtons[posIndex].GetComponentInChildren<Text>().text = humanPlayer.getPlaySymbol();


            //still to spaces available to play... give the turn to human player
            if (gameState.isBoardFull() == false)
            {
                aiPlayer.onGettingPlayTurn(this.gameState);
            }
        }
        

    }


    public void userPlay(int pieceID)
    {
        if (humanPlayer.isItMyTurn())
        {
            humanPlayer.playMove(pieceID);
        }

        
    }








}
