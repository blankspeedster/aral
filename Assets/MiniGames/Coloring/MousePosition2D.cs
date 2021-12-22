using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition2D : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    private void Update() {
         Debug.Log(mainCamera.ScreenToWorldPoint(Input.mousePosition));

         Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
         mouseWorldPosition.z = 0f;
         transform.position = mouseWorldPosition;
    }
}
