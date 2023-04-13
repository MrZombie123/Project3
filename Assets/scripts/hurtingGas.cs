using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtingGas : MonoBehaviour
{
    [SerializeField]private GameObject player;
    private float removeHealth;
   
    // Start is called before the first frame update
   
    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            if(player.GetComponent<playerHealth>().ded == false)
            {
            player.GetComponent<playerHealth>().RemoveHealth(removeHealth);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
