using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public GameObject player;
    
    public checkpointManager checkpointManagerOBJ;

    public SphereCollider collider;
    
    [SerializeField]private Animator animator;
    
    public void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
//        checkpointManagerOBJ = GameObject.FindGameObjectWithTag("checkpoint").GetComponent<checkpointManager>();
    }
    
    void OnTriggerEnter(Collider player)
    { 
       if (player.gameObject.CompareTag("Player"))
       {
            checkpointManagerOBJ.checkpointPosition = this.gameObject;
            checkpointManagerOBJ.CurrentCPP = transform.position;
            Debug.Log("CHECKPOINT!!");
            collider.enabled = false;
            if(animator != null)
            {
            animator.SetBool("grabbed", true);
            }
            
       }
        
    }
    
}
