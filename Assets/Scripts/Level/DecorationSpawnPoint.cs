using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorationSpawnPoint : MonoBehaviour
{
    [SerializeField] private List<GameObject> decorationsPrefabs = new List<GameObject>();
    [SerializeField] private float x;
    [SerializeField] private float y;
    [SerializeField] private float z;
    [SerializeField] private float scale;

    private void Start()
    {
        var instance = Instantiate(decorationsPrefabs[Random.Range(0, decorationsPrefabs.Count)], transform);
        instance.transform.position += 
            new Vector3(x * (Random.value - 0.5f), y * (Random.value - 0.5f), z * (Random.value - 0.5f));
        //instance.transform.localScale *= scale * Random.value;
    }
}
