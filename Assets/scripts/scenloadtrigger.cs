using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scenloadtrigger : MonoBehaviour
{
    public int sceneNumber = 3;
    
    void OnTriggerEnter()
    {
        SceneManager.LoadScene(sceneNumber);
    }

    
}
