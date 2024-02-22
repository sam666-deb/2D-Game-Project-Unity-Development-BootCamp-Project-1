using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanObstacls : MonoBehaviour
{
    public GameObject obstacles;

    public float maxX, minX, maxY, minY;
    public float timeBetweenSpwan;

    public float spwanTime;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= spwanTime)
        {
            Spawn();
            spwanTime = Time.time + timeBetweenSpwan;
        }
    }

    void Spawn()
    {
        float randomY = Random.Range(minY, maxY);
        float randomX = Random.Range(minX, maxX);
        Instantiate(obstacles, transform.position + new Vector3(randomX, randomY, 0), Quaternion.identity);
        
    }
}
