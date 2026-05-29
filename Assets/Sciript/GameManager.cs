using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject youWinEkrani;
    private int kapatılanSayi = 0;

    void Awake()
    {
        instance = this;
    }

    public void KutuKapatildi()
    {
        kapatılanSayi++;

        if (kapatılanSayi >= 4)
        {
            youWinEkrani.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}