using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine
{
    public PlayerState _currentPlayerState;
    public void InitState(PlayerState startState)
    {
        _currentPlayerState = startState;
        _currentPlayerState.Enter();
    }
    public void ChangeState(PlayerState nextState)
    {
        _currentPlayerState.Exit();
        _currentPlayerState = nextState;
        _currentPlayerState.Enter();
    }
}
