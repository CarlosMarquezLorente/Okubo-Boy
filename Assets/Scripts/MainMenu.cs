using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public GameObject obtionMenu;
    public GameObject mainMenu;
    public GameObject extrasMenu;
    public GameObject skinMenu;
    public GameObject soundOption;
    public bool skin;


    public void PlayPulse()
    {
        if (skin == true)
        {
            SceneManager.LoadScene("JuegoSkin");
        }

        if (skin == false)
        {
            SceneManager.LoadScene("Juego");
        }
    }

    public void PlayPulseEng()
    {
        if (skin == true)
        {
            SceneManager.LoadScene("JuegoEngSkin");
        }

        if (skin == false)
        {
            SceneManager.LoadScene("JuegoEng");
        }
    }
    
    public void SkinSelect()
    {
        skin = true;
    }

    public void SkinQuit()
    {
        skin = false;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Options()
    {
        obtionMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void Volver()
    {
        mainMenu.SetActive(true);
        skinMenu.SetActive(false);
        extrasMenu.SetActive(false);
        obtionMenu.SetActive(false);
    }

    public void Desbloqueables()
    {
        mainMenu.SetActive(false);
        skinMenu.SetActive(true);
    }

    public void Extras()
    {
        mainMenu.SetActive(false);
        extrasMenu.SetActive(true);
    }

    public void MenuEsp()
    {
        SceneManager.LoadScene("MainMenuEng");
    }

    public void MenuEng()
    {
        SceneManager.LoadScene("MainMenu2");

    }

    public void Credits()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void CreditsEng()
    {
        SceneManager.LoadScene("MainMenuEng2");
    }

    public void GoCreditsEsp()
    {
        SceneManager.LoadScene("Credits");
    }

    public void GoCreditsEng()
    {
        SceneManager.LoadScene("CreditsEng");
    }
}
