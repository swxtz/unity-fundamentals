using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalLimiter : MonoBehaviour
{
    public float topRange = 33f;
    public float bottomRange = -10f;

    void Update()
    {
        if (transform.position.z > topRange)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomRange)
        {
            Destroy(gameObject);
        }
    }
}
