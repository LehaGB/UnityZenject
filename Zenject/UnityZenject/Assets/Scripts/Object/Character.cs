using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Character : MonoBehaviour,  ICharacter
{
    public event Action OnDeath;

    [SerializeField] private float _speed = 2.5f;

    public Vector3 GetPosition()
    {
        return transform.position;
    }

    public void Move(Vector3 direction, float deltaTime)
    {
        this.transform.position += direction * (deltaTime * this._speed);
    }

    [ContextMenu("Death")]
    public void Death()
    {
        this.OnDeath?.Invoke();
    }
}
