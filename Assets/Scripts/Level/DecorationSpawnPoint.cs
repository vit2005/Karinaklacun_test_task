using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorationSpawnPoint : MonoBehaviour
{
    [SerializeField] private List<GameObject> decorationsPrefabs = new List<GameObject>();
    [SerializeField] private float z;

    private void Start()
    {
        var instance = Instantiate(decorationsPrefabs[Random.Range(0, decorationsPrefabs.Count)], transform);
        instance.transform.position += 
            new Vector3(0f, 0f, z * (Random.value - 0.5f));
    }
}
