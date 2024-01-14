using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEngine : MonoBehaviour
{
    public float animalSpeed = 10f;
   
    void Update()
    {
        transform.Translate(Vector3.forward  * Time.deltaTime * animalSpeed);
    }
}
