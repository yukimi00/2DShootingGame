using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public int health = 1;

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Enemy")) {
            health--;
            Destroy(collision.gameObject);

            if (health <= 0) {
                GameManager.Instance.GameOver();
            }
        }
    }
}
