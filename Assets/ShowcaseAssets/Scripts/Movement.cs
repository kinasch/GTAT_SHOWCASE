using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float moveSpeed = 12f;

    Vector3 velocity;
    
    void Update()
    {
        // Horizontal and Vertical Axis Input take any standardized form of forward/backward
        // and sidewards input (e.g. WASD, Controller Left Joystick, etc.).
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // As moveX and moveZ range from -1 to 1, just multiplying them with the right or forward
        // vector of the player moves the player in the wanted direction.
        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        controller.Move(move * (moveSpeed * Time.deltaTime));
    }
}
