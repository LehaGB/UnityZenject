using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using Zenject;

public class GameController : MonoBehaviour
{
    public bool CanMove;


    [Inject] private TimeController _timeController;
    [Inject] private UIController _uiController;
    [Inject] private UnitPositionController _positionController;
    [Inject] private GameConfig _gameConfig;
    [Inject] private OpponentController.OpponentFabric _opponentFabric;
    [Inject] private PlayerController.PlayerFabric _playerFabric;
    [Inject] private PlayerWorSignal _playerWorSignal;

    [Inject] private GameObject _finishPrefab;

    
    private void Start()
    {
        _uiController?.HideGamePanel();
    }


    private void PlayerWonEvent()
    {

    }


    public void Play()
    {
        _uiController?.HideMenuPanel();
        _uiController?.ShowGamePanel();

        CreateFinish();
        CreatePlayers();
        CreateOpponents();
    }


    private void CreateFinish()
    {
        if (_finishPrefab != null)
        {
            GameObject.Instantiate(_finishPrefab, _gameConfig.finishPos, Quaternion.identity);
        }        
    }


    private void CreateOpponents()
    {
        for (int i = 0; i < _gameConfig.OpponentCount; i++)
        {
            var opponent = _opponentFabric.Create(Random.Range(_gameConfig.OpponentMinSpeed,
           _gameConfig.OpponentMaxSpeed), _gameConfig.finishPos.y, this);
            opponent.transform.position = _positionController.GetNewPos();
        }
    }


    private void CreatePlayers()
    {
        var player = _playerFabric.Create(_gameConfig.PlayerSpeed, _gameConfig.finishPos.y, this);
        player.transform.position = _positionController.GetNewPos();
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
