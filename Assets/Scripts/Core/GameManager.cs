using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour {
    public static GameManager Instance { get; private set; }

    private int Score;

    void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDestroy() {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
        if (scene.name == "MainScene") {
            ResetGame();
        }
    }

    private void ResetGame() {
        Score = 0;
        GameEvents.ScoreChanged(Score);
    }

    public void AddScore(int amount) {
        Score += amount;
        GameEvents.ScoreChanged(Score);
    }
}
