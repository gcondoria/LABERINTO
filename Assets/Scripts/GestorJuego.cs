/// <summary>
/// Modifica los estados del juego
/// y cambia el juego.
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>Define los estados existentes en el Juego a la variable Juego.</summary>
public enum EstadoJuego { Jugando, Victoria, Derrota }
public class GestorJuego : MonoBehaviour
{
    /// <summary>variable estado actual y anterior</summary>
    private EstadoJuego estadoActual = EstadoJuego.Jugando;
    private EstadoJuego estadoAnterior = EstadoJuego.Jugando;
    /// <summary>Obtiene objeto de paneles.</summary>
    [Header("Configuracion paneles")]
    [Tooltip("Ingreso de objeto panel ganaste")]
    [SerializeField] private GameObject panelGanaste;
    [Tooltip("Ingreso de objeto panel perdiste")]
    [SerializeField] private GameObject panelPerdiste;

    /// <summary>
    /// Se encarga de cambiar el estado
    /// respetando la condicionales
    /// en el juego. y activando los paneles.
    /// </summary>
    void Update()
    {
        if (estadoActual == EstadoJuego.Derrota) 
        {
            if (panelPerdiste != null)
            {
                Time.timeScale = 0f;
                panelPerdiste.SetActive(true);
            }
        } else if (estadoActual == EstadoJuego.Victoria) 
        {
            if (panelGanaste != null)
            {
                Time.timeScale = 0f;
                panelGanaste.SetActive(true);
            }
        }
        else if(estadoActual != estadoAnterior)
        {
            estadoAnterior = estadoActual;
        }

    }
    /// <summary>actualiza el estado del juego Victoria.</summary>
    public void JuegoGanado(bool gano) 
    {
        if (gano) 
        {
            estadoActual = EstadoJuego.Victoria;
        }
    }
    /// <summary>actualiza el estado del juego Perdido.</summary>
    public void JuegoPerdido(bool perdio)
    {
        if (perdio)
        {
            estadoActual = EstadoJuego.Derrota;
        }
    }

}
