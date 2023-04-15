using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valve : interactable  
{
    public bool valveTurnedOn;
    //private float spinning = 512f, negSpin = -512f;
    //public float spinMax = 90f;
    //private Transform axis;
    //public float turn;
    //private Vector3 turn;
    [SerializeField]private AudioClip valveOn, valveOff;
    [SerializeField]private AudioSource audioSource;
    [SerializeField]private Animator animator;
    public Collider collider;
    public ParticleSystem particleSystem;
   
    void Update()
    {
       // axis.Rotate(axis: new Vector3(0,1,0), angle: spinning * Time.deltaTime);
    }
    public override void OnInteract()
    {
        var newShape = particleSystem.main;
            if(valveTurnedOn==true)
            {
                audioSource.PlayOneShot(valveOn);
            animator.SetBool("isOpen", true);
            valveTurnedOn=false;  
            collider.enabled = false;

            newShape.loop = false;
            
                //valveTurnedOn = false;
            }
            else
            {
                particleSystem.Play(false);
                audioSource.PlayOneShot(valveOff);
                animator.SetBool("isOpen", false);
                valveTurnedOn=true;  
                newShape.loop = true;
                particleSystem.Play(true);
                collider.enabled = true;
            }
    
    }
        
        
}
