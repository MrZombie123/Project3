using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointManager : MonoBehaviour
{
    public GameObject player;
    
    public GameObject checkpointPosition;
    public Vector3 CurrentCPP;

    //public Transform checkpointTransform;
   
    [SerializeField]private float timer = 1;
    private float timermax = 1;
    [SerializeField]private bool timeron = false;
    private float timermin = 0;
    public GameObject respawnParticles;
    public GameObject particleNet;
    [SerializeField]private AudioSource audioSource;
    [SerializeField]private AudioClip teleport;
    public void OnTriggerEnter(Collider player)
    { 
       if (player.gameObject.CompareTag("Player"))
       {
            
            player.transform.position = checkpointPosition.transform.localPosition;
            
       }
        
    }

  public void OnDeath()
    {
        if(player.GetComponent<playerHealth>().ded == true)
            {
                //character controller was overiding the checkpoint position
                //turning it off first makes the checkpoint position work
                Debug.Log("ded: " + player.GetComponent<playerHealth>().ded);
                timeron = true;

                player.GetComponent<PlayerMovement>().enabled = false;
                //Debug.Log("is control enabled?" + player.GetComponent<PlayerMovement>().enabled);
                player.GetComponent<CharacterController>().enabled = false;
            }
    }
    
    public void Update()
    {
        
        
        if (timeron == true)
        {
           
            timer -= Time.deltaTime;
            float seconds = Mathf.FloorToInt(timer % 60);
            Transform checkpointTransform = checkpointPosition.transform;
            Vector3 checkpointVector = checkpointPosition.transform.position;
            if(timer  <= timermin || Input.GetKey("e"))
                    {
                    
                    timer = timermax;
                    
                    
                    //player.transform.position=checkpointVector;
                    
                    Debug.Log("checkpoint vector is "+checkpointVector);
                    Debug.Log("player vector is " +player.transform.position);
                    Debug.Log("respawn code in progress");

                    timeron = false;

                    float addHealth = 3;
                    player.GetComponent<playerHealth>().ded = false;
                    player.GetComponent<playerHealth>().AddHealth(addHealth);
                    player.transform.position=CurrentCPP;
                   //player.GetComponent<CharacterController>().Move(CurrentCPP);
                    
                    //
                    player.GetComponent<CharacterController>().enabled = true;
                    player.GetComponent<PlayerMovement>().enabled = true;

                    Debug.Log("is control enabled?" + player.GetComponent<PlayerMovement>().enabled);
                    
                    audioSource.PlayOneShot(teleport,1);
                    particleNet=Instantiate(respawnParticles, player.transform.position, player.transform.rotation);
                    
                    Destroy(particleNet,2);
                    //StartCoroutine(WaitForRespwan());
//                  this is where the player should move
                   
                    
                    
                    }
        
                }
                
            }

    
    
} 