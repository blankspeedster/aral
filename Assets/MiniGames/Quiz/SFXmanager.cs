using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXmanager : MonoBehaviour
{
    public static AudioClip sfxCorrect, sfxIncorrect;
    static AudioSource audioSRC;

    // Start is called before the first frame update
    void Start()
    {
        sfxCorrect = Resources.Load<AudioClip>("right");
        
        sfxIncorrect = Resources.Load<AudioClip>("wrong");

        audioSRC = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "correct" :
          //  audioSrc.PlayOneShot(right);
            break;

            case "wrong" :
           // audioSrc.PlayOneShot(wrong);
            break;
        }
    }
}
