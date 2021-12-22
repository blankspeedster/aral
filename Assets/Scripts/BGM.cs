using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
      public AudioClip[] bgm;
      private AudioSource source;

    private void Start() {
        source = FindObjectOfType<AudioSource>();
        source.loop = false;
    }

    private void Update() {
        if (!source.isPlaying)
        {
            source.clip =  bgm[Random.Range(0, bgm.Length)]; 
            
            source.Play();
        }
    }

   
        
   
}
