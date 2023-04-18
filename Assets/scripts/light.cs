using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        eventBus.bus.LightGoOn += LightGoOn;
        eventBus.bus.LightGoOff += LightGoOff;
    }

    // Update is called once per frame
    public void LightGoOn()
    {
        gameObject.GetComponent<Light>().intensity = 2;
    }
    public void LightGoOff()
    {
        gameObject.GetComponent<Light>().intensity = 0;
    }
    public void OnDestroy()
    {
        eventBus.bus.LightGoOn -= LightGoOn;
        eventBus.bus.LightGoOff -= LightGoOff;
    }
}
