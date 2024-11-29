using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private SlopeObject slopePrefab;  // ������ �����
    [SerializeField] private Transform player;         // ��������� ������
    [SerializeField] private float generationDistance = 50f; // ³������, �� ��� ����������� ��� ��������
    [SerializeField] private int initialSlopes = 3;    // ʳ������ ���������� �����

    private Vector3 nextSpawnPoint;                    // ����� ��� ��������� ���������� �����

    private void Start()
    {
        // ����������� ������ ����� �� �����
        for (int i = 0; i < initialSlopes; i++)
        {
            GenerateSlope();
        }
    }

    private void Update()
    {
        // ��������� ����� �����, ���� ������� �����������
        if (Vector3.Distance(player.position, nextSpawnPoint) < generationDistance)
        {
            GenerateSlope();
        }
    }

    private void GenerateSlope()
    {
        // ��������� ������ �����
        SlopeObject newSlope = Instantiate(slopePrefab, nextSpawnPoint, Quaternion.identity);

        // ���������� ����� ���������� ������
        nextSpawnPoint = newSlope.EndMarkerPosition;
    }
}
