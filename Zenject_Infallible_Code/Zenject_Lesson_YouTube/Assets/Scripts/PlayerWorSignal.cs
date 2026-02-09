
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using Zenject;

public class PlayerWorSignal : IInitializable
{
    readonly SignalBus _signalBus;
    public void Initialize()
    {
        _signalBus.Fire(new PlayerWorSignal(_signalBus));
    }
    public PlayerWorSignal(SignalBus signalBus)
    {
        _signalBus = signalBus;
    }
}
