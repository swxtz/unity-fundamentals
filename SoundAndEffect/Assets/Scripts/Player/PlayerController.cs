using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRb; 
    
    public float jumpForce = 200f;
    public float gravityModifier = 0f;

    public bool isGrounded = true;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump(jumpForce);
            isGrounded = false;
        }   
    }

    private void Jump(float jf)
    {
            playerRb.AddForce(Vector3.up * jf, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
