using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmen : MonoBehaviour
{
    [SerializeField]private KeyCode interact = KeyCode.E;
    public int sceneNumber = 0;
    [SerializeField]private bool hasBeenPressed = false;
     [SerializeField] private CanvasGroup canvasGroup;
    //public float fadein = 0.1f;
    // Update is called once per frame
    void Start()
    {
        canvasGroup.alpha = 1f;
        StartCoroutine(FadeOut());
    }
    void Update()
    {
        if(Input.GetKeyDown(interact))
        {
            
            if(hasBeenPressed == false)
            {
                hasBeenPressed = true;
                StartCoroutine(FadeIn());
                
            }
            
        }
    }
    IEnumerator FadeIn()
    {
        float fadeout = 0f;
        
        for (int i = 0; i < 20; i++)
        {
            
            Debug.Log(fadeout);
             fadeout += 0.05f;
             canvasGroup.alpha = fadeout;

            yield return new WaitForSeconds(0.01f);
        }
        SceneManager.LoadScene(sceneNumber);
    }
    IEnumerator FadeOut()
    {
        float fadeIn = 1f;
//        hasBeenPressed = true;
        for (int i = 0; i < 20; i++)
        {
            
            Debug.Log(fadeIn);
             fadeIn -= 0.05f;
             canvasGroup.alpha = fadeIn;

            yield return new WaitForSeconds(0.01f);
        }
       
    }
}
