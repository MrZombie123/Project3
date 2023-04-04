//this is a class for interactions
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class interactable : MonoBehaviour
{
   
    void Awake()
    {
        gameObject.layer = 9;
    }

    public abstract void OnInteract();
    
}
