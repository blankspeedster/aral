using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorTrigger : MonoBehaviour
{

  [SerializeField]
  private DoorAnimated door;

  [SerializeField]
  private GameObject interactables;

  private void OnTriggerEnter(Collider other) {
    door.OpenDoor();
  }

  private void OnTriggerExit(Collider other) {
     door.CloseDoor();
     interactables.gameObject.SetActive(false);
  }
}
