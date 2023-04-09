using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public bool ded;
    [SerializeField]private AudioClip willScream;
    [SerializeField]AudioSource audioSource;
    public checkpointManager checkpointManagerOBJ;

    // Start is called before the first frame update
    public void BecomeDed()
    {
        audioSource.PlayOneShot(willScream,1);
        ded = true;
         checkpointManagerOBJ.GetComponent<checkpointManager>().OnDeath();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
