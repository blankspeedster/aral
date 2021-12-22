using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour
{
  //[SerializeField] private Material myMaterial;
  [SerializeField] private Color myColor;
  [SerializeField] private GameObject myTarget;
 // [SerializeField] List <GameObject> myTarget;
  //[SerializeField] List<Color> myColors = new List<Color>();
  

  private void OnTriggerEnter(Collider other) {
      if (other.CompareTag("Player")) 
      {
          // foreach(var targetObjects in myTarget){
          //   targetObjects.SetActive(false);
          // }
         
          myTarget.GetComponent<Renderer>().material.color =  myColor;

      }
  }
//   private void OnTriggerExit(Collider other) {
//       if (other.CompareTag("Player")) 
//       {
//           myMaterial.color = Color.white;
//       }
//   }


}
