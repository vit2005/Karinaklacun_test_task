using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private SlopeObject slopePrefab;  // Префаб схилу
    [SerializeField] private Transform player;         // Трансформ гравця
    [SerializeField] private float generationDistance = 50f; // Відстань, на якій генеруються нові сегменти
    [SerializeField] private int initialSlopes = 3;    // Кількість початкових схилів

    private Vector3 nextSpawnPoint;                    // Точка для створення наступного схилу

    private void Start()
    {
        // Ініціалізація кількох схилів на старті
        for (int i = 0; i < initialSlopes; i++)
        {
            GenerateSlope();
        }
    }

    private void Update()
    {
        // Генерація нових схилів, коли гравець наближається
        if (Vector3.Distance(player.position, nextSpawnPoint) < generationDistance)
        {
            GenerateSlope();
        }
    }

    private void GenerateSlope()
    {
        // Створення нового схилу
        SlopeObject newSlope = Instantiate(slopePrefab, nextSpawnPoint, Quaternion.identity);

        // Визначення точки наступного спавну
        nextSpawnPoint = newSlope.EndMarkerPosition;
    }
}
