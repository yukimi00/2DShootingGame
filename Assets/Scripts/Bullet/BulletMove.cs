using UnityEngine;

public class BulletMove : MonoBehaviour {
    public float moveSpeed = 10f;

    void Update() {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime, Space.World);

        // 画面範囲の取得
        Vector3 min = Camera.main.ViewportToWorldPoint(new Vector3(0, 0));
        Vector3 max = Camera.main.ViewportToWorldPoint(new Vector3(1, 1));

        // 弾が画面外に出た場合は自身を削除する
        Vector2 pos = transform.position;
        if (
            pos.y > max.y || pos.y < min.y ||
            pos.x > max.x || pos.x < min.x
        ) {
            Destroy(gameObject);
        }
    }
}
