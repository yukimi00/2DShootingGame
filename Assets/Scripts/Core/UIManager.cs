using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI scoreText;

    void OnEnable() {
        GameEvents.OnScoreChanged += UpdateScoreText;
    }

    void OnDisable() {
        GameEvents.OnScoreChanged -= UpdateScoreText;
    }

    private void UpdateScoreText(int newScore) {
        scoreText.text = $"Score: {newScore}";
    }
}
