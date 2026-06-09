/// <summary>
/// Lee el estado actual del personaje.
/// retorna el estado por consola.
/// </summary>

using UnityEngine;
/// <summary>Define los estados existentes en el Jugador a la variable Jugador.</summary>
public enum EstadoJugador { Quieto, Moviendo, EnMeta }
public class GestorEstados : MonoBehaviour
{
    /// <summary>Asigna el estado inicial a Quieto.</summary>
    private EstadoJugador estadoActual = EstadoJugador.Quieto;
    /// <summary>Asigna el estado incial a Quieto.</summary>
    private EstadoJugador estadoAnterior = EstadoJugador.Quieto;
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
            Debug.Log("Estado actual: " + estadoActual);
            estadoAnterior = estadoActual;
        }

    }
    /// <summary>
    /// Detecta si hubo una colision con el objeto meta y asigna a estado Meta.
    /// retorna el estado por consola.
    /// </summary>
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.CompareTag("Meta"))
        {
            estadoActual = EstadoJugador.EnMeta;
            Debug.Log("Estado actual: " + estadoActual);
            Destroy(c.gameObject);
        }

    }

}

