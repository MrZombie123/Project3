//this is an example of an interactable script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : interactable  
{
    [SerializeField]AudioSource audioSource;
    [SerializeField]AudioClip buttonpressed;
//    private bool buttonPressed=false;
//    public string objectAnimation;
//    public Animator myObject;
    // Start is called before the first frame update
    [SerializeField]private float time = 2;
    [SerializeField]private float maxTime = 2;
    
    public override void OnInteract()
    {
        time = maxTime;
        audioSource.PlayOneShot(buttonpressed,1);
        Debug.Log ("testing interact");
        eventBus.bus.BlockSwitchOnTrigger();
       
       StartCoroutine(timesTicking());
        
        
    }
    IEnumerator timesTicking()
    {
        for (int i = 0; i < maxTime; i++)
        {
            
        time--;
        
        yield return new WaitForSeconds(1);
        }
        //put it after the coroutine because it didn't fire off in OnInteract
        if(time <= 0)
                {
                    Debug.Log("hello 1?");
                    eventBus.bus.BlockSwitchOffTrigger();
                }
                
    }
    

}
