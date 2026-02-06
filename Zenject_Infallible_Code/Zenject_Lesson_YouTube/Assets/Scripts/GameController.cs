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

    [Inject] private UnitPositionController _positionController;

    private void Start()
    {
        Debug.Log(_positionController.GetNewPos());
        Debug.Log(_positionController.GetNewPos());
    }

    public void Play()
    {

    }


    public void Restart()
    {

    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
