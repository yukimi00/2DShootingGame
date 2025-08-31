using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    public int health = 1;

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Bullet")) {
            health--;
            Destroy(collision.gameObject);
            if (health >= 0) {
                GameManager.Instance.AddScore(1);
                Destroy(gameObject);
            }
        }
    }
}
