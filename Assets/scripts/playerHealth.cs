using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public float health=3f;
    public float maxHealth = 3f;
    public bool ded;
    //private float removeHealth = 1f;
    //private float addHealth = 1f;
    //[SerializeField]private Slider slider;
    public checkpointManager checkpointManagerOBJ;
    public GameObject Canvas;
    [SerializeField]private AudioSource audioSource;
    [SerializeField]private AudioClip willScream;
    public void RemoveHealth(float removeHealth)
    {
        health -= 0.1f;
        UpdateUI();
        if(health <= 0f)
        {
            BecomeDed();
        }
    }
    public void AddHealth(float addHealth)
    {
        health += maxHealth;
         UpdateUI();
    }
    public void BecomeDed()
    {
        
        audioSource.PlayOneShot(willScream,1);
        ded = true;
        health = 0f;
        UpdateUI();
         checkpointManagerOBJ.GetComponent<checkpointManager>().OnDeath();
        
    }

    // Update is called once per frame
    void UpdateUI()
    {
        Canvas.GetComponent<UImanager>().UpdateUI();
    }
}
