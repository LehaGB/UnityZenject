using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel;
    [SerializeField] private GameObject _gamePanel;

    private GameController _gameController;

#if UNITY_EDITOR

    // Добавление ссылок в иерархии(движок делает это сам).
    private void OnValidate()
    {
        _menuPanel = transform.Find("PanelMainMenu").gameObject;
        _gamePanel = transform.Find("GamePanel").gameObject;
    }
#endif

    public void ShowMenuPanel()
    {
        _menuPanel?.SetActive(true);
    }


    public void HideMenuPanel()
    {
        _menuPanel?.SetActive(false);
    }


    public void ShowGamePanel()
    {
        _gamePanel?.SetActive(true);
    }


    public void HideGamePanel()
    {
        _gamePanel?.SetActive(false);
    }


    public void OnExitButtonClicked()
    {
        _gameController?.Exit();
    }


    public void OnPlayButtonClicked()
    {
        _gameController?.Play();
    }


    public void OnRestartButtonClicked()
    {
        _gameController?.Restart();
    }
}
