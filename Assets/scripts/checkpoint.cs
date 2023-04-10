using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public GameObject player;
    
    public checkpointManager checkpointManagerOBJ;

    public SphereCollider collider;
    
    
    
    public void Awake()
    {
        
        checkpointManagerOBJ = GameObject.FindGameObjectWithTag("checkpoint").GetComponent<checkpointManager>();
    }
    
    void OnTriggerEnter(Collider player)
    { 
       if (player.gameObject.CompareTag("Player"))
       {
            checkpointManagerOBJ.checkpointPosition = this.gameObject;
            Debug.Log("CHECKPOINT!!");
            collider.enabled = false;
       }
        
    }
    
}
