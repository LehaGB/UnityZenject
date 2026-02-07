using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;


[CreateAssetMenu(fileName = "SOInstaller", menuName = "Create SO Installer")]
public class SOInstaller : ScriptableObjectInstaller
{
    [SerializeField] private GameConfig _gameConfig;
    [SerializeField] private GameObject _finishPrefab;

    public override void InstallBindings()
    {
        Container.BindInstance(_gameConfig);
        Container.BindInstance(_finishPrefab);
    }
}
