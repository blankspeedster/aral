using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPalette : MonoBehaviour
{
    [SerializeField] private Material setMaterial;
    AudioSource audioSource;
    public AudioClip colorSound;
    
     private void Awake() {
        gameObject.AddComponent<AudioSource>();
        audioSource = GetComponent<AudioSource>();
    
    }
   

   private void OnTriggerEnter(Collider other) {
       if (other.gameObject.tag == "Player"){
           ColorOnClick.myMaterial = setMaterial;
           audioSource.PlayOneShot(colorSound, 1F);
           print(ColorOnClick.myMaterial);
       }
   }
   
}
