using System;
using UnityEngine;

public static class GameEvents
{

    public static Action<int> OnScoreChanged;  // Send added score
    public static Action<int> OnMovesChanged;  // Send changed move (-1)
    public static Action<bool> OnLevelEnded;   // true = Victory, false = Defeat

    public static Action OnInputLocked;        // Stop the player from click
    public static Action OnInputUnlocked;      // Allow the player to click

}
