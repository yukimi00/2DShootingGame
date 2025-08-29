using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMove : MonoBehaviour {
    public float moveSpeed = 5f;
    private float inputMoveX = 0f;
    private float inputMoveY = 0f;

    void Update() {
        // 入力受付
        inputMoveX = Input.GetAxis("Horizontal");
        inputMoveY = Input.GetAxis("Vertical");

        // 移動
        Vector3 movement = new Vector3(inputMoveX, inputMoveY, 0);
        transform.position += movement * moveSpeed * Time.deltaTime;
    }
}
