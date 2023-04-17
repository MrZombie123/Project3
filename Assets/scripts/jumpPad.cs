using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpPad : MonoBehaviour
{
    [SerializeField]
    private Transform[] fansTransform= new Transform[3]; 
    [SerializeField] float fansSpeed = 512f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Transform fantransform= ;
        //fantransform.Rotate(fansSpeed*0,1,0*Time.deltaTime);
    }
}
