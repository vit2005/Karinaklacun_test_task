using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSpawnPoint : MonoBehaviour
{
    [SerializeField] private List<GameObject> obstaclesPrefabs = new List<GameObject>();
    [SerializeField] private GameObject coinPrefab;
    [Range(0f, 1f)] [SerializeField] private float obstacleProbability;
    [Range(0f, 1f)] [SerializeField] private float coinProbability;
    [SerializeField] private float x;


    void Start()
    {
        GameObject instance = null;
        if (Random.value < obstacleProbability)
        {
            instance = Instantiate(obstaclesPrefabs[Random.Range(0, obstaclesPrefabs.Count)], transform);
            instance.transform.Rotate(new Vector3(90f * (Random.value - 0.5f), 90f * (Random.value - 0.5f), 90f * (Random.value - 0.5f)));
        }
        else if (Random.value < coinProbability)
        {
            instance = Instantiate(coinPrefab, transform);
            instance.transform.position += Vector3.up * 0.5f;
        }
        
        if (instance) instance.transform.position += new Vector3(x * (Random.value - 0.5f), 0f, 0f);
    }
}
