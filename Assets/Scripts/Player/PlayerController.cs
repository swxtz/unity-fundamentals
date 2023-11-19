using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float velocity;
    public float mass;
    public float turnSpeed;
    public TMP_Text speedmeter;

    public float horizontalInput;
    public float verticalInput;

    void Start()
    {
        GetComponent<Rigidbody>().mass = mass;
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * Time.deltaTime * velocity * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        speedmeter.text = "Km/H " + velocity.ToString();
    }
}
