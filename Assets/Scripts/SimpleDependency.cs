using UnityEngine;
using System.Collections;

public class SimpleDependency : ISimpleDependency {

    public void SayHello()
    {
        Debug.Log("Hello");
    }
}
