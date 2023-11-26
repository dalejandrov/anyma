using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Main()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
    public void HowPlay()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Config");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Creditos");
    }
    public void Exit()
    {
        Application.Quit();
    }
}