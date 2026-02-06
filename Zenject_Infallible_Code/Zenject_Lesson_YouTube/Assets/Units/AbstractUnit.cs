using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractUnit : MonoBehaviour
{
    protected float _speed;
    protected float _finishPos;
    protected GameController _gameController;

    private void Update()
    {
        if (_gameController.CanMove)
        {

        }
    }
    protected abstract void Move();
}
