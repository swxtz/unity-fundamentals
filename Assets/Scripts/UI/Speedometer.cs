using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// TODO: Futuro codigo

public class Speedometer : MonoBehaviour
{

    public TMP_Text text;
    private float speed;

    void Start()
    {
        speed = GetComponent<PlayerController>().velocity;
    }

    void Update()
    {
        text.text = "Km/H " + speed;
    }
}
