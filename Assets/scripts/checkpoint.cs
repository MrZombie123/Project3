using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public GameObject player;
    
    //public Vector3 checkpointPosition;
    
    public checkpointManager checkpointManagerOBJ;

    public SphereCollider collider;
    
    [SerializeField]private bool HBCollected = false;
    
    public void Awake()
    {
        //collider = gameObject.GetComponent<Collider>();
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
