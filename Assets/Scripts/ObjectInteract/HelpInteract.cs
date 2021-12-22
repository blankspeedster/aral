using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpInteract : MonoBehaviour
{
    [SerializeField]
    private GameObject myPanel;

    private void Start() {
        myPanel.SetActive(false);
    }
    private void OnTriggerEnter(Collider other) {
        myPanel.SetActive(true);
    }

    private void OnTriggerExit(Collider other) {
        myPanel.SetActive(false);
    }
}
