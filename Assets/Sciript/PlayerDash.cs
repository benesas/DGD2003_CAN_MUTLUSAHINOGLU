using UnityEngine;

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
        // Cooldown sayacı
        if (cooldownTimer > 0)
            cooldownTimer -= Time.deltaTime;

        // Dash başlatma (Shift tuşu)
        if (Input.GetKeyDown(KeyCode.LeftShift) && cooldownTimer <= 0 && !isDashing)
        {
            StartDash();
        }

        // Dash devam ediyorsa
        if (isDashing)
        {
            dashTimer -= Time.deltaTime;
            controller.Move(dashDirection * dashSpeed * Time.deltaTime);

            if (dashTimer <= 0)
            {
                isDashing = false;
            }
        }
    }

    void StartDash()
    {
        isDashing = true;
        dashTimer = dashTime;
        cooldownTimer = dashCooldown;

        // Karakterin baktığı yöne dash atar
        dashDirection = transform.forward;
    }
}