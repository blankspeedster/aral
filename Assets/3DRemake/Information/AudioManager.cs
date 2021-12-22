using System;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public Sounds[] sound;

    private void Awake() {
        foreach (Sounds s in sound){
           s.source = gameObject.AddComponent<AudioSource>();
           s.source.clip = s.clip;

           s.source.volume = s.volume;
           s.source.pitch = s.pitch;
        }
    }

    public void Play(string name){
        Sounds s = Array.Find(sound, Sounds =>  Sounds.name == name);
        s.source.Play();
    }
}
