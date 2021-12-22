 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectInteract : MonoBehaviour
{
   
    public GameObject trigger;
     
  
   // public static ObjectInteract Instance;

    private void Start() {
        trigger.gameObject.SetActive(false);
       
    }

     void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Lilitaw dito dapat");
           trigger.gameObject.SetActive(true);
          
           
            
        }
    }

    void OnTriggerExit(Collider other){
        Debug.Log("Maglalaho dito");
        trigger.gameObject.SetActive(false);
        //Destroy(dialogButton);
    }

}
