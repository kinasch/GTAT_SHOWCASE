using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float moveSpeed = 12f;

    Vector3 velocity;

    // Update is called once per frame
    void Update()
    {
        //Keyboard Input
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        //Movement
        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        controller.Move(move * (moveSpeed * Time.deltaTime));
    }
}
