using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBasePlayer  {


    void setCurrentGameState(GameState gS);
    
    void onGettingPlayTurn(GameState currentState);

    bool isItMyTurn();

    void setTurn(bool isTurn);

    string getPlaySymbol();

}
