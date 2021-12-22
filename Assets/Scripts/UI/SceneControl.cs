using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
 
   public void Home() {
        SceneManager.LoadScene("Menu");
    }
   public void ResetScene() {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ReturnSchool() {
         SceneManager.LoadScene("School01");
    }
}
