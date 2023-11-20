using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float velocity;
    private float speed;
    
    public float mass;
    
    public float turnSpeed = 50f;
    public TMP_Text speedmeter;

    public float horizontalInput;
    public float verticalInput;

    public Rigidbody car;

    public bool showSpeed;

    void Start()
    {
        GetComponent<Rigidbody>().mass = mass;
    }

    void Update()
    {

        speed = car.velocity.x * 3.6f;

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (verticalInput != 0)
        {
            //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        }

        transform.Translate(Vector3.forward * Time.deltaTime * velocity * verticalInput);


        if(Input.GetKeyDown(KeyCode.F9))
        {
            showSpeed = !showSpeed;
        }

        if(showSpeed)
        {
            speedmeter.text = "Km/H " + speed.ToString();
        }else
        {
            speedmeter.text = "";
        }
    }
}
