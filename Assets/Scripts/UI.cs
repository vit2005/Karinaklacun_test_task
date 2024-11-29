using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    private static UI _instance;
    public static UI Instance => _instance;

    [SerializeField] private TextMeshProUGUI coinsCounter;

    private void Awake()
    {
        _instance = this;
    }

    public void SetCoins(int value)
    {
        coinsCounter.text = value.ToString();
    }
}
