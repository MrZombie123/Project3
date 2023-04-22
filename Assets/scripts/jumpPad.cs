using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpPad : MonoBehaviour
{
    [SerializeField] private Transform[] fansTransform= new Transform[2]; 
    private Transform fanTransform;
//    private Quaternion quat;
    [SerializeField]private PlayerMovement player;
    [SerializeField] private float fansSpeed = 16f;
    [SerializeField]private Collider collider;
    public float thrust = 32f;
    public Rigidbody rb;
    public ParticleSystem[] particleArray = new ParticleSystem[2];
    public ParticleSystem particle;
    // Start is called before the first frame update
    void Start()
    {
        particle = particleArray[particleArray.Length-1];
 //       fanTransform = fansTransform[fansTransform.Length-1];
 //       quat = fanTransform.rotation;
      
    }

    // Update is called once per frame
    void Update()
    {
        PlayParticle();
//        fanTransform.Rotate(0f,1f*fansSpeed*Time.deltaTime,0f);
//        Debug.Log(quat);
       
    }
    IEnumerator PlayParticle()
    {
        for (int i = 0; i < 1; i++)
        {
        Debug.Log("particle is"+particle);    
        particle.Play();
        
        yield return new WaitForSeconds(2);
        }

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
