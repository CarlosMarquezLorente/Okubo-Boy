using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeadPanel : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    public void PlayEngSkin()
    {
        SceneManager.LoadScene("JuegoEngSkin");
    }

    public void PlaySkin()
    {
        SceneManager.LoadScene("JuegoSkin");
    }
    
    public void PlayPulseEng()
    {
        SceneManager.LoadScene("JuegoEng");
    }

    public void PlayPulse()

    {
        SceneManager.LoadScene("Juego");
        // StartCoroutine(EsperarPlay());

    }

    public void ExitButton()
    {
        // StartCoroutine(EsperarVolver());
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitButtonEng()
    {
        // StartCoroutine(EsperarVolver());
        SceneManager.LoadScene("MainMenuEng2");
    }
}
