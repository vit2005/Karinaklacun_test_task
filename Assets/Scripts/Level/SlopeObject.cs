using UnityEngine;

public class SlopeObject : MonoBehaviour
{
    [SerializeField] private GameObject endMarker;  // ќб'Їкт, що визначаЇ к≥нець схилу
    public Vector3 EndMarkerPosition => endMarker.transform.position;
}
