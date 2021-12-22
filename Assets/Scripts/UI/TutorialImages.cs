using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialImages : MonoBehaviour
{
   public GameObject[] images;
   int index;
   public int pages;
   public Button myButton;

   private void Start() {
       index = 0;
   }

   private void Awake() {
       for (int i = 0; i < images.Length; i++)
       {
           images[i].gameObject.SetActive(false);
       }
   }

   private void Update() {
       if (index >= pages)
       index = pages;

       if(index < 0 )
       index = 0;

       if (index == 0)
       {
           images[0].gameObject.SetActive(true);
       } 
       if (pages == 3)
       {
           myButton.gameObject.SetActive(false);
       }    
   }

   public void Next() {
       index +=1; 

       for(int i=0 ; i < images.Length; i++)
       {
           images[i].gameObject.SetActive(false);
           images[index].gameObject.SetActive(true);
          
       }
       
       Debug.Log(index);
   }

   public void Previous(){
       index -=1; 

       for(int i=0 ; i < images.Length; i++)
       {
           images[i].gameObject.SetActive(false);
           images[index].gameObject.SetActive(true);
       }
       Debug.Log(index);
   }


}
