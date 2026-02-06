using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class UnitPositionController
{
    [Inject] private GameConfig _gameConfig;

    private int _posCounter;

    public Vector3 GetNewPos()
    {
        _posCounter++;
        return _gameConfig.StartPos + new Vector3(_posCounter * _gameConfig.DistanceBetweenOpponents, 0, 0);
    }

    public void Reset()
    {
        _posCounter = 0;
    }
}
