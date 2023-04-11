using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointManager : MonoBehaviour
{
    public GameObject player;
    
    public GameObject checkpointPosition;

    //public Transform checkpointTransform;
   
    [SerializeField]private float timer = 1;
    private float timermax = 1;
    [SerializeField]private bool timeron = false;
    private float timermin = 0;
    
    
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
                Debug.Log("ded: " + player.GetComponent<playerHealth>().ded);
                timeron = true;

                player.GetComponent<PlayerMovement>().enabled = false;
                Debug.Log("is control enabled?" + player.GetComponent<PlayerMovement>().enabled);
            }
    }
    public void Update()
    {
        if (timeron == true)
        {
            Transform checkpointTransform = checkpointPosition.transform;
            Vector3 checkpointVector = checkpointPosition.transform.position;
            timer -= Time.deltaTime;
            float seconds = Mathf.FloorToInt(timer % 60);
            if(timer  <= timermin || Input.GetKey("e"))
                    {
                    
                    timer = timermax;
                    
                    Debug.Log("respawn code in progress");

                    player.transform.position=checkpointVector;
//                  this is where the player should move
                    Debug.Log(checkpointVector);
                    
                    timeron = false;
                    float addHealth = 3;
                    player.GetComponent<playerHealth>().ded = false;
                    player.GetComponent<playerHealth>().AddHealth(addHealth) ;
                    player.GetComponent<PlayerMovement>().enabled = true;
                    Debug.Log("is control enabled?" + player.GetComponent<PlayerMovement>().enabled);
                    }

        }
        
    }
} 