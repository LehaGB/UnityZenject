using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Zenject;


[CreateAssetMenu(fileName = "GameConfig", menuName = "Greate game config")]
public class GameConfig : ScriptableObject
{
    public int OpponentCount;
    public float OpponentMinSpeed;
    public float OpponentMaxSpeed;
    public float PlayerSpeed;
    public Vector3 StartPos;
    public Vector3 finishPos;
    public float DistanceBetweenOpponents;
    public GameObject PlayerPrefab;
    public GameObject OpponentPrefab;
}
