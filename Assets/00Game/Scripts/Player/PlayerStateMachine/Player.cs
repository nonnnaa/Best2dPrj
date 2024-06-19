using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerStateMachine _playerStateMachine;
    public Animator _animator;
    public PlayerData _playerData;
    public PlayerInputHandler _playerInputHandler;

    public IdleState _idleState;
    public MoveState _moveState;
    private void Awake()
    {
        _playerStateMachine = new PlayerStateMachine();

        _idleState = new IdleState(this, _playerData, _playerStateMachine, "idle");
        _moveState = new MoveState(this, _playerData, _playerStateMachine, "move");

    }
    void Start()
    {
        _playerStateMachine.InitState(_idleState);
        _animator = GetComponent<Animator>();
        _playerInputHandler = GetComponent<PlayerInputHandler>();
    }

    
    void Update()
    {
        _playerStateMachine._currentPlayerState.LogicsUpdate();
    }
    private void FixedUpdate()
    {
        _playerStateMachine._currentPlayerState.PhysicsUpdate();
    }
}
