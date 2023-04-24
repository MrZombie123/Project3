using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UImanager : MonoBehaviour
{
    [SerializeField]private Slider slider;
    [SerializeField]private Text text;
    [SerializeField]private AudioSource audioSource;
    [SerializeField]private AudioClip fart;
    public GameObject stats;
    public button1 timer;
    public float health;
    public float textFloat;

    // Start is called before the first frame update

    // Update is called once per frame
    public void UpdateUI()
    {
        health = stats.GetComponent<playerHealth>().health;
        slider.value=health;
    }
    public void UpdateNumbers()
    {
        textFloat = timer.GetComponent<button1>().time;
        DisplayTime(textFloat);
    }
    public void DisplayTime(float textFloat)
    {
        textFloat-=1f;
        //used this tutorial: https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/
        float minutes = Mathf.FloorToInt(textFloat / 60); 
        float seconds = Mathf.FloorToInt(textFloat % 60);
        text.text = string.Format("{00:00}:{01:00}", minutes, seconds);
        if(textFloat <= 0)
        {
            audioSource.PlayOneShot(fart,1);
            string stringNull = "";
            text.text = stringNull;
        }
    }
}
