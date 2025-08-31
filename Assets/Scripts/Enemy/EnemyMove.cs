using UnityEngine;

public class EnemyMove : MonoBehaviour {
    public float moveSpeed = 5f;

    void Update() {
        Move();
    }

    void Move() {
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);

        if (transform.position.y < -5f) {
            Destroy(transform.gameObject);
        }
    }
}
