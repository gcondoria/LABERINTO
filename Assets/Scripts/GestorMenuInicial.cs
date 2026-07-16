/// <summary>
/// Se encarga del menu incial
/// Modifica los botones en menu
/// y cambia el juego
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestorMenuInicial : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 1f;
    }
    /// <summary>empieza el juego</summary>
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    /// <summary>Sale del juego</summary>
    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
    /// <summary>Reinicia el juego en el nivel donde esta.</summary>
    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    /// <summary>actualiza el siguiente nivel</summary>
    public void SiguienteNivel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    /// <summary>Desplaza al menu inicial</summary>
    public void MInicial()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    /// <summary>Desplaza a el nievel 1</summary>
    public void Nivel1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
    /// <summary>Desplaza a el nievel 2</summary>
    public void Nivel2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
    }
}
