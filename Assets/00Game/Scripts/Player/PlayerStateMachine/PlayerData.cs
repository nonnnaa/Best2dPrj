using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "PlayerData", menuName = "Scriptable_Object/Player_Data")]
public class PlayerData : ScriptableObject
{
    public float _hp;
    public float _mp;
    public float moveSpeed;
    public float _jumpPower;
}
