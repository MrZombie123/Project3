using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpPad : MonoBehaviour
{
    [SerializeField] private Transform[] fansTransform= new Transform[2]; 
    private Transform fanTransform;
    [SerializeField]private PlayerMovement player;
    [SerializeField] private float fansSpeed = 512f;
    [SerializeField]private Collider collider;

    public List<Quaternion> originalRotations = new List<Quaternion>();
    // Start is called before the first frame update
    void Start()
    {
      //fanTransform[0] = //Set the 0 value here
      //fanTransform[1] = //Set the 1 value here
    }

    // Update is called once per frame
    void Update()
    {
        fanTransform.Rotate(fansSpeed*0,1,0*Time.deltaTime);
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("should jump now");
            player.gravity = -10;
        }
    }
}
