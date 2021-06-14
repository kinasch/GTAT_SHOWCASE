using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookScript : MonoBehaviour
{
    public float mouseSens = 100f;
    public Transform player;
    float xRot = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //hides cursor ingame
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90f, 75f); // verhindert überrotation

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);
    }
}
