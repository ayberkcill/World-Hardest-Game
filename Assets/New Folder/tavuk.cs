using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tavuk : Canlilar,IWalkaAble,IFlyAble
{
    public void Fly()
    {

    }

    public void Walk()
    {

    }

    private void Start()
    {
        beslen();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        IWalkaAble bla=other.GetComponent<IWalkaAble>();
        if(bla != null)
        {
            bla.Walk();
        }
    }
}
