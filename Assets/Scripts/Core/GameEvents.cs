using System;

public class GameEvents {
    public static event Action<int> OnScoreChanged;

    public static void ScoreChanged(int newScore) {
        OnScoreChanged?.Invoke(newScore);
    }
}
