using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneloader : MonoBehaviour
{
    public int[] SceneNumber;
	

    public void Sceneload(Scene scene)
	{
		
			for (int i = 0; i < SceneNumber.Length; i++)
			{
				SceneManager.LoadScene(SceneNumber[i]);
			}
 		
	}
}
