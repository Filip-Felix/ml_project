using UnityEngine;

public class FreeCamera : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float lookSpeed = 2f;

    private float yaw = 0f;
    private float pitch = 0f;

    void Update()
    {
        // Mișcare
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float upDown = 0f;

        if (Input.GetKey(KeyCode.E)) upDown = 1f;
        if (Input.GetKey(KeyCode.Q)) upDown = -1f;

        Vector3 move = new Vector3(h, upDown, v) * moveSpeed * Time.deltaTime;
        transform.Translate(move);

        // Rotire mouse
        if (Input.GetMouseButton(1)) // click dreapta
        {
            yaw += lookSpeed * Input.GetAxis("Mouse X");
            pitch -= lookSpeed * Input.GetAxis("Mouse Y");
            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
    }
}