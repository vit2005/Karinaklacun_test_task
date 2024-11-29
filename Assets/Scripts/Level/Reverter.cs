using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reverter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Vector3 pos = other.transform.position;
        pos.x = 0f;
        pos.y += 2f;
        other.transform.position = pos;
        other.GetComponent<Rigidbody>().velocity = Vector3.zero;
        other.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

    }
}
