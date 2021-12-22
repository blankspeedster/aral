using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphabetInteract : MonoBehaviour
{
    public AudioClip impact;
    AudioSource audioSource;
    public GameObject alphabetPanel;

 
    public GameObject myTrigger;
    // Start is called before the first frame update
    void Start()
    {
         audioSource = GetComponent<AudioSource>();
         alphabetPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(myTrigger.transform.position, Vector3.up, 20 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) {
         if (other.gameObject.tag == "Player")
        {
            alphabetPanel.SetActive(true);
            audioSource.PlayOneShot(impact, 1F);       
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            alphabetPanel.SetActive(false);
        }
    }
    
}
