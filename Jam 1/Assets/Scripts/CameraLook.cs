using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class CameraLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    private float xRotation = 0f;

    private Vector2 mouseDelta;

    public Transform playerBody;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void OnLook(InputAction.CallbackContext context)
    {
        mouseDelta = context.ReadValue<Vector2>();
    }

    void Update()
    {
        float mouseX = mouseDelta.x * mouseSensitivity * Time.deltaTime;
        float mouseY = mouseDelta.y * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);


    }

}
