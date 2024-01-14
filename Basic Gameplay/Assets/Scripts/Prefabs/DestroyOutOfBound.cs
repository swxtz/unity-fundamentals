using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private int topBound = 33;
    private int lowBound = -10;

    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if(transform.position.z < lowBound)
        {
            Destroy(gameObject);
        }
    }
}
