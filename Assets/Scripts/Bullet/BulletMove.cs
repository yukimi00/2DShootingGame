using UnityEngine;

public class BulletMove : MonoBehaviour {
    public float moveSpeed = 10f;

    void Start() {
        transform.rotation = Quaternion.Euler(0, 0, 45);
    }

    void Update() {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime, Space.World);
    }
}
