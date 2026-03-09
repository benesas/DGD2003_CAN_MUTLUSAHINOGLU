using UnityEngine;

public class EyeFollow : MonoBehaviour
{
    public Transform player;   // oyuncu
    public float speed = 5f;   // takip hızı

    void Update()
    {
        if (player != null)
        {
            Vector3 direction = player.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
        }
    }
}