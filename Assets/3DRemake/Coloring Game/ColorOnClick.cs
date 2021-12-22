using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorOnClick : MonoBehaviour
{
    public static Material myMaterial;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)){
                Debug.Log(hit.transform.name);
                if (hit.transform.gameObject.tag == "Colorable" && myMaterial != null){
                    hit.transform.GetComponent<Renderer>().material = myMaterial;
                }
                
            }
        }

    }
}
