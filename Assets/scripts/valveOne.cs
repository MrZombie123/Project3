using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valveOne : interactable  
{
    public bool valveTurnedOn;
    private float spinning = 512f, negSpin = -512f;
    //public float spinMax = 90f;
    private Transform axis;
    //public float turn;
    //private Vector3 turn;
    [SerializeField]private AudioClip valveOn, valveOff;
    [SerializeField]private AudioSource audioSource;
    void Start()
    {
        axis = gameObject.transform;
    }
    void Update()
    {
       // axis.Rotate(axis: new Vector3(0,1,0), angle: spinning * Time.deltaTime);
    }
    public override void OnInteract()
    {
        if(valveTurnedOn==true)
        {
            audioSource.PlayOneShot(valveOn);
            spinning=1f;
             StartCoroutine(TurnValveOn());
            //valveTurnedOn = false;
        }
        else
        {
            audioSource.PlayOneShot(valveOff);
            spinning=-1f;
            StartCoroutine(TurnValveOFF());
            
        }
    
    }
        
        IEnumerator TurnValveOn()
        {
            for (int i = 0; i < 32; i++)
            {
                
                axis.Rotate(axis: new Vector3(0,1,0), angle: spinning * Time.deltaTime);
            
            yield return new WaitForSeconds(0.01f);
            }
            valveTurnedOn = false;
        }     
        IEnumerator TurnValveOFF()
        {
            for (int i = 0; i < 32; i++)
            {
 
                axis.Rotate(axis: new Vector3(0,1,0), angle: negSpin * Time.deltaTime);
            
            yield return new WaitForSeconds(0.01f);
            }
            valveTurnedOn = true;
            //valveTurnedOn = false;
        }     
   
    
  

}
