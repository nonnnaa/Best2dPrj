using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    protected Player _player;
    protected PlayerData _playerData;
    protected PlayerStateMachine _playerStateMachine;
    protected float _startTime;

    private string _animBoolName;

    public PlayerState(Player player, PlayerData playerData, PlayerStateMachine playerStateMachine, string animBoolName)
    {
        _player = player;
        _playerData = playerData;
        _playerStateMachine = playerStateMachine;
        _animBoolName = animBoolName;
    }
    public virtual void Enter()
    {
        DoChecks();
        _player._animator.SetBool(_animBoolName, true);
        _startTime = Time.time; 
    }
    public virtual void Exit()
    {
        _player._animator.SetBool(_animBoolName, false);
    }
    public virtual void PhysicsUpdate()
    {

    }
    public virtual void LogicsUpdate()
    {

    }

    public virtual void DoChecks()
    {

    }
}
