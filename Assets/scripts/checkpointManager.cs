using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointManager : MonoBehaviour
{
    public Transform player;
    
    public GameObject checkpointPosition;

     public Transform checkpointTransform;
   
    [SerializeField]private float timer = 1;
    private float timermax = 5;
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
                
                timeron = true;

                
                
            }
    }
    public void Update()
    {
        if (timeron == true)
        {
            checkpointTransform = checkpointPosition.transform;
            Vector3 checkpointVector = checkpointPosition.transform.position;
            timer -= Time.deltaTime;
            float seconds = Mathf.FloorToInt(timer % 60);
            if(timer  < timermin || Input.GetKey("e"))
                    {
                    timer = timermax;
                    
                    Debug.Log("respawn code in progress");

                    GameObject.FindGameObjectWithTag("Player").transform.position=checkpointVector;
//                  this is where the player should move

                    player.GetComponent<playerHealth>().ded = false;
                    timeron = false;
                    }
        }
        
    }
} 