using UnityEngine;
using Zenject;

public class SimpleInstaller : MonoInstaller<SimpleInstaller>
{
    public override void InstallBindings()
    {
        Container.Bind<ITickable>().To<SimpleScript>().AsSingle();
        Container.Bind<ISimpleDependency>().To<SimpleDependency>().AsSingle();
        Container.Bind<SimpleScript>();
    }
}