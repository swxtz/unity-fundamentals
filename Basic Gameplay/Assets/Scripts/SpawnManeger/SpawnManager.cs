using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefab;

    // random position values
    private float xRange = 20;
    private float zPos = 20;


    void Update()
    {
       if(Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0, animalsPrefab.Length);
            Vector3 randPos = new Vector3(Random.Range(-xRange, xRange), 0, zPos);
            Instantiate(animalsPrefab[animalIndex], randPos, animalsPrefab[animalIndex].transform.rotation);
        } 
    }
}
