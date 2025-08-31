using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public static GameManager Instance { get; private set; }

    private int Score;
    public bool IsGameOver { get; private set; }

    void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.R) && IsGameOver) {
            ReStart();
        }
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
        IsGameOver = false;
    }

    private void ReStart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddScore(int amount) {
        Score += amount;
        GameEvents.ScoreChanged(Score);
    }

    public void GameOver() {
        GameEvents.GameOver();
        IsGameOver = true;
    }
}
