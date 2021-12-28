using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderboardTrigger : MonoBehaviour
{

    public GameObject scoreboardCanvas;
    public GameObject inputCanvas;
    // Start is called before the first frame update
    void Awake()
    {
        scoreboardCanvas.gameObject.SetActive(false);
        
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player")
        {
            inputCanvas.gameObject.SetActive(false);
            scoreboardCanvas.gameObject.SetActive(true);
        }
    }

    public void CloseCanvas()
    {
        scoreboardCanvas.gameObject.SetActive(false);
        inputCanvas.gameObject.SetActive(true);
    }

   
}
