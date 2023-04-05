using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPopup : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;
    public float fadeIn = 0f;
    [SerializeField] private float fadeInMax = 1f;
    [SerializeField]private bool HBSeen = false;
   public void OnTriggerEnter(Collider collider)
    {
        Debug.Log("trigger collide");
        if(HBSeen == false)
        {
           
                //fadeIn += Time.deltaTime;
                Debug.Log("should see something here");
            canvasGroup.alpha = fadeIn / (fadeInMax * 1.0f);
            HBSeen = true;
           
        }
    }
    public void OnButtonClick()
    {
        canvasGroup.alpha = 0f;
    }
}
