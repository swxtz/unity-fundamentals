using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform orietation;

    private float horizontalInput;
    private float verticalInput;

    private float mouseY;
    private float mouseX;

    private float xRotation;
    private float yRotation;

    public float speed = 10.0f;
    public float sensi = 10.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }



    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        mouseY = Input.GetAxisRaw("Mouse Y");
        mouseX = Input.GetAxisRaw("Mouse X");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orietation.rotation = Quaternion.Euler(0, yRotation, 0);



    }
}
