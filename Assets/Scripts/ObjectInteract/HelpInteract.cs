using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpInteract : MonoBehaviour
{
    [SerializeField]
    private GameObject myPanel;
    [SerializeField]
    private GameObject myObject;

    private void Start() {
        myPanel.SetActive(false);
        myObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player"){
        myPanel.SetActive(true);
        myObject.SetActive(true);
        }        
       
    }

    private void OnTriggerExit(Collider other) {
        myPanel.SetActive(false);
        Destroy(this.gameObject);
        
    }
}
