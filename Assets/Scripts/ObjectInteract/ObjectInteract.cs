 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectInteract : MonoBehaviour
{
   
    public GameObject trigger;
     

    private void Start() {
        trigger.gameObject.SetActive(false);
       
    }

     void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
       
           trigger.gameObject.SetActive(true);
            
        }
    }

    void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "Player")
        {
            trigger.gameObject.SetActive(false);
        }
    }

}
