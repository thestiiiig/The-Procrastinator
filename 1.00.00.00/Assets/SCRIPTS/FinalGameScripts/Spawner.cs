using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 1f; //the rate of spawning

    public GameObject hexagonPrefab; //hexagon prefab

    private float nextTimeToSpawn = 0f; 



    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTimeToSpawn)
        {
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity); //spawn a new hexagon at the centre with no rotation
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
    }
}
