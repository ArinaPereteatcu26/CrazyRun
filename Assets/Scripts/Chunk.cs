using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    
    [SerializeField] GameObject fencePrefab;
    [SerializeField] float[] lanes = {-2f, 0f, 2f};

    void Start()
    {
        SpawnFence();
    }

    void SpawnFence()
    {
        List<int> availableLanes = new List<int> { 0, 1, 2 }; // Indices of available lanes

        int fencesToSpawn = Random.Range(0, lanes.Length); 

        for (int i = 0; i < fencesToSpawn; i++)
        {
            if (availableLanes.Count <= 0) break; // No more lanes available
            int randomLaneIndex = Random.Range(0, availableLanes.Count);
            int selectedLane = availableLanes[randomLaneIndex];
            availableLanes.RemoveAt(randomLaneIndex); // Remove the selected lane to avoid duplicates

            Vector3 spawnPosition = new Vector3(lanes[selectedLane], transform.position.y, transform.position.z);
            Instantiate(fencePrefab, spawnPosition, Quaternion.identity, this.transform);
        }
            
    }
}
