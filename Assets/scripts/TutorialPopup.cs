using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPopup : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;
    public float fadeIn = 0.1f;
    public float fadeInMax = 10f;
    [SerializeField] private bool HBSeen = false;
    public GameObject player;
   
   public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
       { 
        Debug.Log("trigger collide");
        if(HBSeen == false)
            {
                player.GetComponent<PlayerMovement>().enabled = false;
                StartCoroutine(Fade());
            Cursor.visible = true;
                    //fadeIn += Time.deltaTime;
                
                //canvasGroup.alpha = fadeIn / (fadeInMax * 1.0f);
                HBSeen = true;
            
            }
        }
    }
    IEnumerator Fade()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("should see something here");
             fadeIn += 0.1f;
             canvasGroup.alpha = fadeIn;

            yield return new WaitForSeconds(0.01f);
        }

    }
    public void OnButtonClick()
    {
        canvasGroup.alpha = 0f;
        Cursor.visible = false;
        player.GetComponent<PlayerMovement>().enabled = true;
    }
}
