using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerDash : MonoBehaviour
{
    public float dashSpeed = 20f;
    public float dashTime = 0.2f;
    public float dashCooldown = 1f;

    private CharacterController controller;
    private Vector3 dashDirection;
    private bool isDashing = false;
    private float dashTimer;
    private float cooldownTimer;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (cooldownTimer > 0)
            cooldownTimer -= Time.deltaTime;

        if (Keyboard.current.leftShiftKey.wasPressedThisFrame && cooldownTimer <= 0 && !isDashing)
        {
            StartDash();
        }

        if (isDashing)
        {
            dashTimer -= Time.deltaTime;
            controller.Move(dashDirection * dashSpeed * Time.deltaTime);

            if (dashTimer <= 0)
                isDashing = false;
        }
    }

    void StartDash()
    {
        isDashing = true;
        dashTimer = dashTime;
        cooldownTimer = dashCooldown;
        dashDirection = transform.forward;
    }
}