/// <summary>
/// Se encarga de actualizar en la pantalla el estado del jugador
/// </summary>
using TMPro;
using UnityEngine;

public class VistaEstadoJugador : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    /// <summary>CVariable estado jugador.</summary>
    private string estadoJugador;
    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();

    }
    /// <summary>Actualiza el estado actual en el textMesh</summary>
    private void Update()
    {
        if (textMesh != null)
        {
            textMesh.text = estadoJugador;
        }
    }
    /// <summary>obtiene el estado y lo guarda en la variable</summary>
    public void MostrarEstado(string estadoActualJugador)
    {
        estadoJugador = estadoActualJugador;
    }
}
