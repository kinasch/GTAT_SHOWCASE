using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookScript : MonoBehaviour
{
    public float mouseSens = 100f;
    public Transform player;
    float xRot = 0f;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //hides cursor ingame
    }
    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90f, 75f); // Prevents the camera from over rotating

        // The Mouse Y input is the rotation around the global X axis.
        // This only applies to the camera, as the player should not rotate around this X axis, thus the this.transform.
        this.transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        // The rotation around the Y axis, via the Mouse X, is applied to the player,
        // as well as the camera, as the player's child.
        player.Rotate(Vector3.up * mouseX);
    }
}
