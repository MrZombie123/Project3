using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSfx : MonoBehaviour
{
    public AudioClip[] sfx;//= Array.Empty<AudioClip>();
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play_SFX(int index)
    {
       audioSource.PlayOneShot(sfx[index],1);
		                
    }
}
