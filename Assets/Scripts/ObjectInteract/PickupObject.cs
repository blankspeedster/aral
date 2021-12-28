using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{

    public Transform guide;

    //Hold Objects for shapes
    public void HoldObject() {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)){
               var pickupItem = hit.transform.gameObject.tag;
                switch (pickupItem)
                {
                    case "Kahon":
                    hit.transform.parent = guide.transform;
                    hit.transform.position = guide.transform.position;
                   
                    break;
                     case "Star":
                    hit.transform.parent = guide.transform;
                    hit.transform.position = guide.transform.position;
                    break;
                     case "Cone":
                    hit.transform.parent = guide.transform;
                    hit.transform.position = guide.transform.position;
                    break;
                     case "Rectangle":
                    hit.transform.parent = guide.transform;
                    hit.transform.position = guide.transform.position;
                    
                    break;
                     case "Bilog":
                    hit.transform.parent = guide.transform;
                    hit.transform.position = guide.transform.position;
                    break;

                }
                
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        HoldObject(); 
       
    }
}
