using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;
using Zenject;

public sealed class ScneInstaller : MonoInstaller

{
    [SerializeField] private Character character1;

    //[SerializeField] private Character character2;
    public override void InstallBindings()
    {
        this.Container
            .Bind<ICharacter>()
            .To<Character>()
            .FromInstance(this.character1)
            .AsSingle();

        //this.Container
        //    .Bind<ICharacter>()
        //    .To<Character>()
        //    .FromInstance(this.character2)
        //    .AsSingle();
    }
}
