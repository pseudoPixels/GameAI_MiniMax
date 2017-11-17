using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPlayer : BasePlayer
{
    public AIPlayer(GameManager gM) : base(gM)
    {
    }

    public override void onGettingPlayTurn(GameState currentState)
    {
        throw new NotImplementedException();
    }
}
