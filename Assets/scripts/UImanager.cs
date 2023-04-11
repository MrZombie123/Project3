using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UImanager : MonoBehaviour
{
    [SerializeField]private Slider slider;
    public GameObject stats;
    public float health;
    // Start is called before the first frame update

    // Update is called once per frame
    public void UpdateUI()
    {
        health = stats.GetComponent<playerHealth>().health;
        slider.value=health;
    }
}
