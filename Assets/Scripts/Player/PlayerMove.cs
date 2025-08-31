using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public float moveSpeed = 5f;
    private float halfWidth, halfHeight;

    void Start() {
        // スプライトの半サイズを取得している
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        halfWidth = sr.bounds.extents.x;
        halfHeight = sr.bounds.extents.y;
    }

    void Update() {
        if (GameManager.Instance.IsGameOver) return;

        // 入力受付
        float inputMoveX = Input.GetAxis("Horizontal");
        float inputMoveY = Input.GetAxis("Vertical");

        // 移動
        Vector3 movement = new Vector3(inputMoveX, inputMoveY, 0);
        transform.position += movement * moveSpeed * Time.deltaTime;

        // 画面範囲の取得
        Vector3 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector3 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, min.x + halfWidth, max.x - halfWidth);
        pos.y = Mathf.Clamp(pos.y, min.y + halfHeight, max.y - halfHeight);

        transform.position = pos;
    }
}
