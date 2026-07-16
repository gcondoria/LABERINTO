/// <summary>
/// Se encarga de detectar Meta 
/// y enviar mensaje al gestor de estados,
/// </summary>
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeteccionMeta : MonoBehaviour
{
    /// <summary>Obtiene objeto gestor juego.</summary>
    [Header("Configuracion Gestor")]
    [Tooltip("Ingreso de objeto estadod e juego")]
    [SerializeField] private GestorJuego estadoJuego;

    /// <summary>
    /// Se encarga de detectar Meta comparandolo 
    /// con la etiqueta Jugador.Luego llama a la funcion JuegoGanado
    ///  para avisar que hubo colision.
    /// </summary>
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Jugador"))
        {
            estadoJuego.JuegoGanado(true);
        }
    }
}
