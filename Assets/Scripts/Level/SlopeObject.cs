using UnityEngine;

public class SlopeObject : MonoBehaviour
{
    [SerializeField] private GameObject endMarker;  // ��'���, �� ������� ����� �����
    public Vector3 EndMarkerPosition => endMarker.transform.position;
}
