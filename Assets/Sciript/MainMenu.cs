using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Slider sesSlider;
    public AudioSource muzik;

    void Start()
    {
        float kayitliSes = PlayerPrefs.GetFloat("SesAyari", 1f);
        sesSlider.value = kayitliSes;
        muzik.volume = kayitliSes;
    }

    public void OyunuBaslat()
    {
        SceneManager.LoadScene("oyun");
    }

    public void SesAyarla(float deger)
    {
        muzik.volume = deger;
        PlayerPrefs.SetFloat("SesAyari", deger);
    }
}