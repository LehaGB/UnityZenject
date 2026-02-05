using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacter
{
    event Action OnDeath;

    void Move(Vector3 direction, float deltaTime);

    Vector3 GetPosition();
}
