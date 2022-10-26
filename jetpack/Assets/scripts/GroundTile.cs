using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    
    
    void Start()
    {
        groundSpawner = FindObjectOfType<GroundSpawner>();
        int rd = Random.Range(1, 3);
        if(rd == 1)
            SpawnObstacle();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 5);
    }
    
    void Update()
    {
        
    }

    public GameObject obstiaclePrefab;

    void SpawnObstacle()
    {
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        Instantiate(obstiaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }
}
