using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonPuzzle : MonoBehaviour
{
    private void OnEnable()
    {
        GameManager.instance.UpdateGameState(GameState.Puzzle);
    }
}
