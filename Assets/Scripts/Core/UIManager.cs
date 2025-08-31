using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI gameOverText;

    void OnEnable() {
        GameEvents.OnScoreChanged += UpdateScoreText;
        GameEvents.OnGameOver += ShowGameOver;
    }

    void Start() {
        gameOverText.gameObject.SetActive(false);
    }

    void OnDisable() {
        GameEvents.OnScoreChanged -= UpdateScoreText;
        GameEvents.OnGameOver -= ShowGameOver;
    }

    private void UpdateScoreText(int newScore) {
        scoreText.text = $"Score: {newScore}";
    }

    private void ShowGameOver() {
        gameOverText.gameObject.SetActive(true);
    }
}
