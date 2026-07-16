/// <summary>
/// Se encarga de actualizar en la pantalla la velocidad del jugador
/// </summary>
using TMPro;
using UnityEngine;

public class VistaVelocidad : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    /// <summary>CVariable velocidad jugador.</summary>
    private float velocidadJugador;
    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();

    }
    /// <summary>Actualiza el estado actual en el textMesh</summary>
    private void Update()
    {
        if (textMesh != null)
        {
            textMesh.text = velocidadJugador.ToString();
        }
    }
    /// <summary>obtiene la velocidad y lo guarda en la variable</summary>
    public void MostrarEstado(float velocidadActualJugador)
    {
        velocidadJugador = velocidadActualJugador;
    }
}
