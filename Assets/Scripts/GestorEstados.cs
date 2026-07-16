/// <summary>
/// Lee el estado actual del personaje.
/// retorna el estado por consola.
/// </summary>

using UnityEngine;
/// <summary>Define los estados existentes en el Jugador a la variable Jugador.</summary>
public enum EstadoJugador { Quieto, Moviendo,Comiendo,Corriendo}
public class GestorEstados : MonoBehaviour
{
    /// <summary>Asigna el estado inicial a Quieto.</summary>
    private EstadoJugador estadoActual = EstadoJugador.Quieto;
    /// <summary>Asigna el estado incial a Quieto.</summary>
    private EstadoJugador estadoAnterior = EstadoJugador.Quieto;
    [SerializeField] private VistaEstadoJugador vistaEstado;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    /// <summary>
    /// Lee los input y detecta si esta en movimiento o quieto.
    /// retorna por consola el estado segun cada cambio de estado.
    /// </summary>
    void Update()
    {
        float input = Mathf.Abs(Input.GetAxis("Vertical")) +
                      Mathf.Abs(Input.GetAxis("Horizontal"));
        estadoActual = (input > 0.1f) ? EstadoJugador.Moviendo : EstadoJugador.Quieto;
        if (estadoActual != estadoAnterior)
        {
            vistaEstado.MostrarEstado(estadoActual.ToString());
            Debug.Log("Estado actual: " + estadoActual);
            estadoAnterior = estadoActual;
        }

    }
    /// <summary>
    /// Detecta si hubo una colision con el objeto estado bonus y asigna a estado comiendo.
    /// retorna el estado por consola.
    /// </summary>
    public void BonusEstado()
    {
        estadoActual = EstadoJugador.Comiendo;
        Debug.Log("Estado actual: " + estadoActual);
    }
    /// <summary>
    /// Detecta si hubo una colision con el objeto estado manzana y asigna a estado corriendo.
    /// retorna el estado por consola.
    /// </summary>
    public void ManzanaEstado()
    {
        estadoActual = EstadoJugador.Corriendo;
        Debug.Log("Estado actual: " + estadoActual);
    }
}

