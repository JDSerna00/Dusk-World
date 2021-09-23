using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void EscenaJuego()
    {
        SceneManager.LoadScene("Game");
    }

    public void EscenaCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void EscenaMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
