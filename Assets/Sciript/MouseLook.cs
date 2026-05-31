using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Camera playerCamera;
    public float minFOV = 60f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        if (playerCamera == null)
            playerCamera = Camera.main;

        // Kamera clipping düzeltme
        playerCamera.nearClipPlane = 0.01f;
    }

    void Update()
    {
        if (Mouse.current == null) return;

        float mouseX = Mouse.current.delta.x.ReadValue() * mouseSensitivity * Time.deltaTime;
        transform.Rotate(Vector3.up * mouseX);
    }
}