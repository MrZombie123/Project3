//this is an example of an interactable script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : interactable  
{
    [SerializeField]AudioSource audioSource;
    [SerializeField]AudioClip buttonpressed;
    // Start is called before the first frame update
    public override void OnInteract()
    {
        audioSource.PlayOneShot(buttonpressed,1);
        Debug.Log ("testing interact");
    }

}
