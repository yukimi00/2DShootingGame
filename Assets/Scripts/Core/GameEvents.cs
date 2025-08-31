using System;

public class GameEvents {
    public static event Action<int> OnScoreChanged;
    public static event Action OnGameOver;

    public static void ScoreChanged(int newScore) {
        OnScoreChanged?.Invoke(newScore);
    }

    public static void GameOver() {
        OnGameOver?.Invoke();
    }
}
