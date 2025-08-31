using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    [SerializeField] GameObject enemyPrefab;
    public float spawnInterval = 2f;
    public float spawnRangeX = 8f;
    void Start() {
        InvokeRepeating("SpawnEnemy", 1f, spawnInterval);
    }

    void SpawnEnemy() {
        if (GameManager.Instance.IsGameOver) return;

        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPos = new Vector3(randomX, transform.position.y, 0);

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}
