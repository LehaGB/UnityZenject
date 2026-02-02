using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public sealed class DeathObserver : IInitializable, IDisposable
{
    private readonly ICharacter _character;
    private readonly GameManager _gameManager;

    public DeathObserver(ICharacter character, GameManager gameManager)
    {
        this._character = character;
        this._gameManager = gameManager;
    }

    void IInitializable.Initialize()
    {
        this._character.OnDeath += this._gameManager.FinishGame();
    }

    void IDisposable.Dispose()
    {
        this._character.OnDeath -= this._gameManager.FinishGame();
    }
}
