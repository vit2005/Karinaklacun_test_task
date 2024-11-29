using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsController : MonoBehaviour
{
    private static CoinsController _instance;
    public static CoinsController Instance => _instance;

    private int count = 0;

    private void Awake()
    {
        _instance = this;
    }

    public void Increment()
    {
        count++;
        UI.Instance.SetCoins(count);
    }
}
