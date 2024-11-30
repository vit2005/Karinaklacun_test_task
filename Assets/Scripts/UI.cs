using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    private static UI _instance;
    public static UI Instance => _instance;

    [SerializeField] private TextMeshProUGUI coinsCounter;
    [SerializeField] private GameObject startMenu;
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private InputSystem inputSystem;

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        Time.timeScale = 0f;
    }

    public void SetCoins(int value)
    {
        coinsCounter.text = value.ToString();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(!pauseMenu.activeSelf);
            Time.timeScale = pauseMenu.activeSelf ? 0.01f : 1f;
        }
    }

    public void OnStartClick()
    {
        inputSystem.enabled = true;
        startMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OnRetartClick()
    {
        SceneManager.LoadScene(0);
    }

    public void OnExitClick()
    {
        Application.Quit();
    }
}
