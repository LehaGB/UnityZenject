using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [Inject] private GameConfig _gameconfig;
    public override void InstallBindings()
    {
        Container.Bind<TimeController>().AsSingle();
        Container.Bind<UnitPositionController>().AsSingle();
        Container.DeclareSignal<PlayerWorSignal>();

        Container.BindFactory<float, float, GameController, PlayerController,
            PlayerController.PlayerFabric>().FromComponentInNewPrefab(_gameconfig.PlayerPrefab)
            .WithGameObjectName("Player");

        Container.BindFactory<float, float, GameController, OpponentController,
            OpponentController.OpponentFabric>().FromComponentInNewPrefab(_gameconfig.OpponentPrefab)
            .WithGameObjectName("Enemy");
    }
}
