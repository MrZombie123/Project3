using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpPad : MonoBehaviour
{
    [SerializeField] private Transform[] fansTransform= new Transform[2]; 
    private Transform fanTransform;
    private Quaternion quat;
    [SerializeField]private PlayerMovement player;
    [SerializeField] private float fansSpeed = 512f;
    [SerializeField]private Collider collider;
    public float thrust = 32f;
    public Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
        fanTransform = fansTransform[fansTransform.Length-1];
        quat = fanTransform.rotation;
      
    }

    // Update is called once per frame
    void Update()
    {
 //      quat.Euler(fansSpeed*0,1,0*Time.deltaTime);
    }
    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            player.velocity.y += thrust;
            Debug.Log("should jump now");
            
        }
      
        if(collider.TryGetComponent<Rigidbody>(out Rigidbody rb))
        {
            Debug.Log("force added");
            rb.AddForce(0, thrust,0 , ForceMode.Impulse);
        }
        //wow this works?
    }
}
