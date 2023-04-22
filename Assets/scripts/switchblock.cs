using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchblock : MonoBehaviour
{
    [SerializeField]private Material materialOne, materialTwo;
    public bool switchblockOni;
    
    void Start()
    {
        eventBus.bus.BlockSwitchOn += BlockSwitchOn;
        eventBus.bus.BlockSwitchOff += BlockSwitchOff;
        if(switchblockOni == true)
        {
            gameObject.GetComponent<Renderer>().material=materialOne;
            gameObject.GetComponent<Collider>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material=materialTwo;
            gameObject.GetComponent<Collider>().enabled = false;
        }
    }
    

    
    public void BlockSwitchOn()
    {
        
        
        gameObject.GetComponent<Renderer>().material=materialOne;
        gameObject.GetComponent<Collider>().enabled = true;
        switchblockOni = true;
        
    }
    
    
    
    public void BlockSwitchOff()
    {
        
        gameObject.GetComponent<Renderer>().material=materialTwo;
        gameObject.GetComponent<Collider>().enabled = false;
        switchblockOni = false;
    }
    public void OnDestroy()
    {
        eventBus.bus.BlockSwitchOn -= BlockSwitchOn;
        eventBus.bus.BlockSwitchOff -= BlockSwitchOff;
    }
}
