using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Canlilar : MonoBehaviour, IWalkaAble
{
    public void Run()
    {
    }

    public void Walk()
    {
        throw new System.NotImplementedException();
    }

    protected void beslen()
    {
        print("Yey");
    }
}
public interface IWalkaAble
{
    public void Walk();
    public void Run();
}
public interface IFlyAble
{
    public void Fly();
}
