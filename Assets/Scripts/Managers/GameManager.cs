using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public static GameState _state;

    public void UpdateGameState(GameState state)
    {
        switch (state)
        {
            case GameState.MainMenu:

                break;
            case GameState.CutScene:

                break;
            case GameState.InGame:

                break;
            case GameState.Puzzle:
                Player.instance.gameObject.SetActive(false);
                break;
        }
    }
}

public enum GameState
{
    MainMenu,
    CutScene,
    InGame,
    Puzzle,
    Final,
}
