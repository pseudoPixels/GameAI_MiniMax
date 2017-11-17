using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanPlayer : BasePlayer
{
    public HumanPlayer(GameManager gM) : base(gM)
    {
    }

    public override void onGettingPlayTurn(GameState currentState)
    {
        throw new NotImplementedException();
    }
}
