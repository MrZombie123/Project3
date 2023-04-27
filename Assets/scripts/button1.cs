//this is an example of an interactable script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : interactable  
{
    [SerializeField]AudioSource audioSource;
    [SerializeField]AudioClip buttonpressed;
    [SerializeField]private bool buttonPressed=false;
//    public string objectAnimation;
//    public Animator myObject;
    // Start is called before the first frame update
    public float time = 2;
    public UImanager uiManager;
    [SerializeField]private float maxTime = 2;
    [SerializeField]private Animator animator;
    
    public override void OnInteract()
    {
        
        
//        Debug.Log ("testing interact");
        
       if (buttonPressed==false)
       {
        animator.SetBool("isPressed", true);
        time = maxTime;
        audioSource.PlayOneShot(buttonpressed,1);
        eventBus.bus.BlockSwitchOnTrigger();
        buttonPressed=true;
       StartCoroutine(timesTicking());
      
       }
        
    }
    IEnumerator timesTicking()
    {
        
        for (int i = 0; i < maxTime; i++)
        {
        float textFloat = time;
        uiManager.GetComponent<UImanager>().DisplayTime(textFloat);    
        time--;
        
        yield return new WaitForSeconds(1);
        }
        //put it after the coroutine because it didn't fire off in OnInteract
        if(time <= 0)
                {
                    Debug.Log("hello 1?");
                    eventBus.bus.BlockSwitchOffTrigger();
                    buttonPressed=false; 
                    animator.SetBool("isPressed", false);
                }
                
    }
    

}
