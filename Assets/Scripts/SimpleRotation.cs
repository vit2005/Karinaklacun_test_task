using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SimpleRotation : MonoBehaviour
{
    [SerializeField] private Vector3 rotation = Vector3.zero;

    void Update()
    {
        transform.Rotate(rotation, Space.World);
    }
}
