using UnityEngine;
using UnityEngine.InputSystem;

public class ElektrikKutusu : MonoBehaviour
{
    public bool kapatildi = false;

    void Update()
    {
        if (kapatildi) return;

        float mesafe = Vector3.Distance(transform.position, 
            GameObject.FindWithTag("Player").transform.position);

        if (mesafe < 2f && Keyboard.current.eKey.wasPressedThisFrame)
        {
            kapatildi = true;
            GameManager.instance.KutuKapatildi();
            gameObject.SetActive(false);
        }
    }
}