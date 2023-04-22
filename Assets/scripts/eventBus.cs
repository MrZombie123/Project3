using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventBus : MonoBehaviour
{
    private static eventBus _bus;
    public static eventBus bus{get{return _bus;}}
    
    void Awake()
    {
        if(_bus != null && _bus != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _bus = this;
        }
    }

    public event Action LightGoOn;
    public void LightGoOnTrigger()
        {
            LightGoOn();
        }
    
    public event Action LightGoOff;
    public void LightGoOffTrigger()
        {
            LightGoOff();
        }
    
    public event Action BlockSwitchOn;
    public void BlockSwitchOnTrigger()
    {
        BlockSwitchOn();
    }

    public event Action BlockSwitchOff;
    public void BlockSwitchOffTrigger()
    {
        BlockSwitchOff();
        Debug.Log("hello?");
    }
}
