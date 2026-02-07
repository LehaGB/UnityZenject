using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using Zenject;

public class GameController : MonoBehaviour
{
    public bool CanMove {  get; private set; }


    [Inject] private TimeController _timeController;
    [Inject] private UIController _uiController;
    [Inject] private UnitPositionController _positionController;

    [Inject] private GameObject _finishPrefab;

    private void Start()
    {
        _uiController?.HideGamePanel();
    }


    private void CreateFinish()
    {
        Debug.Log($"_finishPrefab in GameController is: {_finishPrefab}");
        if (_finishPrefab != null)
        {
            GameObject.Instantiate(_finishPrefab);
            Debug.Log("Create Prefab");
        }
        
    }

    public void Play()
    {
        _uiController?.HideMenuPanel();
        _uiController?.ShowGamePanel();
        Debug.Log("Скрываем меню");
        CreateFinish();
        Debug.Log("Вызываем метод для создания префаба");
    }


    public void Restart()
    {
        _uiController?.ShowMenuPanel();
        _uiController?.HideGamePanel();
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        Debug.Log("Exit");
#else
        Application.Quit();      
#endif
    }
}
