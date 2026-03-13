using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMoodController : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Keyboard.current.digit1Key.wasPressedThisFrame)
        {
            anim.SetFloat("Mood", 1f); // Idle
        }

        if (Keyboard.current.digit2Key.wasPressedThisFrame)
        {
            anim.SetFloat("Mood", 2f); // Happy
        }

        if (Keyboard.current.digit3Key.wasPressedThisFrame)
        {
            anim.SetFloat("Mood", 0f); // Sad
        }

        if (Keyboard.current.digit4Key.wasPressedThisFrame)
        {
            anim.SetFloat("Mood", 3f); // Dance
        }
    }
}