using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefab;

    // random position values
    private float xRange = 20;
    private float zPos = 20;

    private float startInterval = 2;
    private float spawnInverval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startInterval, spawnInverval);    
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalsPrefab.Length);
        Vector3 randPos = new Vector3(Random.Range(-xRange, xRange), 0, zPos);
        Instantiate(animalsPrefab[animalIndex], randPos, animalsPrefab[animalIndex].transform.rotation);
    }
}
