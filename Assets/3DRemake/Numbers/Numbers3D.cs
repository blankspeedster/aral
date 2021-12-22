using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Numbers3D : MonoBehaviour
{
     
     AudioSource audioSource;
     public AudioClip numberSound;

    private void Awake() {
        gameObject.AddComponent<AudioSource>();
        audioSource = GetComponent<AudioSource>();
    
    }
   
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag =="Player"){
           audioSource.PlayOneShot(numberSound, 0.8F);
        }
    }
   
}
