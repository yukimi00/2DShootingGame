using UnityEngine;

public class PlayerAttack : MonoBehaviour {
    [SerializeField] GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float fireRate = 0.25f;
    private float nextFireTime = 0f;

    void Update() {
        if (GameManager.Instance.IsGameOver) return;

        if (Input.GetMouseButtonDown(0) && Time.time > nextFireTime) {
            Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
            nextFireTime = Time.time + fireRate;
        }
    }
}
