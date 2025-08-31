using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    public int health = 1;

    void Update() {

    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Bullet")) {
            health--;
            Destroy(collision.gameObject);
            if (health >= 0) {
                Destroy(gameObject);
            }
        }
    }
}
