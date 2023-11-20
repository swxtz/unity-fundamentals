using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private int yRange = 33;

    void Update()
    {
        if (transform.position.z > yRange)
        {
            Destroy(GameObject);
        }
    }
}
