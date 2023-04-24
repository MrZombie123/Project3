using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pit : MonoBehaviour
{
    public GameObject player;
    public GameObject checkpointManager;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider player)
    {
        if(player.tag == "Player")
        {
            player.GetComponent<playerHealth>().BecomeDed();
        }
        
    }
}
