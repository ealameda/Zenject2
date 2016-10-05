using UnityEngine;
using System.Collections;
using Zenject;

public class SimpleScript : ITickable
{
    private ISimpleDependency simpleDependency;

    public SimpleScript(ISimpleDependency simpleDependency)
    {
        this.simpleDependency = simpleDependency;
        this.simpleDependency.SayHello();
    }

    public void Tick()
    {
        Debug.Log("Ticking...");
    }
}
