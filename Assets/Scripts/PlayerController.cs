using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float velocity;
    public float mass;
    public TMP_Text speedmeter;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().mass = mass;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * velocity);
        speedmeter.text = "Km/H " + velocity.ToString();
    }
}
