using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameManager 
{
    public event Action OnGameStarted;
    public event Action OnGamePaused;
    public event Action OnGameResumed;
    public event Action OnGameFinished;

    public GameState State {  get; private set; }

    public void StartGame()
    {
        if(this.State != GameState.OFF)
        {
            return;
        }

        this.State = GameState.PLAY;
        this.OnGameStarted?.Invoke();
        Debug.Log("Started Game");
    }


    public void PauseGame()
    {
        if(this.State != GameState.PLAY)
        {
            return;
        }

        this.State = GameState.PAUSE;
        this.OnGamePaused?.Invoke();
        Debug.Log("Pause Game");
    }


    public void ResumeGame()
    {
        if(this.State != GameState.PAUSE)
        {
            return;
        }

        this.State = GameState.PLAY;
        this.OnGameResumed?.Invoke();
        Debug.Log("Resume Game");
    }

    public void FinishGame()
    {
        if(this.State is GameState.PAUSE or GameState.PLAY)
        {
            return;
        }

        this.State = GameState.FINISH;
        this.OnGameFinished?.Invoke();
        Debug.Log("Finished Game");
    }
}
