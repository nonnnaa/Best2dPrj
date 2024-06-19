using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedState : PlayerState
{
    public Vector2 _inputMovement;
    public GroundedState(Player player, PlayerData playerData, PlayerStateMachine playerStateMachine, string animBoolName) : base(player, playerData, playerStateMachine, animBoolName)
    {
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicsUpdate()
    {
        base.LogicsUpdate();
        _inputMovement = _player._playerInputHandler._movement;
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
