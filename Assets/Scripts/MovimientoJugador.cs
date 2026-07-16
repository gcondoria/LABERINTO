/// <summary>
/// Controla el movimiento físico del personaje usando Rigidbody.
/// Debe coexistir con el script InputManager en el mismo GameObject.
/// </summary>

using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovimientoJugador : MonoBehaviour
{
    /// <summary>Velocidad de desplazamiento en unidades por segundo.</summary>
    [Header("Movimiento")]
    [Tooltip("Velocidad de avance y retroceso del jugador en unidades/segundo.")]
    [Range(1f, 20f)]
    [SerializeField] private float velocidad = 5f;
    /// <summary>Velocidad de giro sobre su propio eje en unidades por segundo.</summary>
    [Tooltip("Velocidad de giro sobre su propio eje del jugador en unidades/segundo.")]
    [Range(30f, 360f)]
    [SerializeField] private float velocidadGiro = 120f;
    /// <summary>Objeto vista velocidad</summary>
    [Tooltip("Objeto Vista Velocidad ")]
    [SerializeField] private VistaVelocidad vistaVelocidad;
    private Rigidbody rb;
    private InputManager inputManager;

    /// <summary>
    /// Llama al componente Rigidbody.
    /// Obtiene datos del script InputManager.
    /// </summary>
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        inputManager = GetComponent<InputManager>();
        vistaVelocidad.MostrarEstado(velocidad);
    }

    /// <summary>
    /// Lee y asisgna a una variable el dato de Input manager de Movimiento Horizontal y Vertical.
    /// Procede a mover a la posicion dada.
    /// </summary>
    void FixedUpdate()
    {
        float giro = inputManager.MovimientoHorizontal;
        transform.Rotate(Vector3.up, giro * velocidadGiro * Time.fixedDeltaTime);

        float avance = inputManager.MovimientoVertical;
        Vector3 mov = transform.forward * avance * velocidad * Time.fixedDeltaTime;

        rb.MovePosition(rb.position + mov);
    }
    /// <summary>
    /// Aumenta la velocidad del jugador a 1.
    /// Obtiene aviso de el objeto vista velocidad.
    /// </summary>
    public void velocidadAumento()
    {
        velocidad = velocidad + 1f;
        vistaVelocidad.MostrarEstado(velocidad);
    }
}
