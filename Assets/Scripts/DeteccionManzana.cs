using UnityEngine;

public class DeteccionManzana : MonoBehaviour
{
    /// <summary>Configura las manzanas acumuladas.</summary>
    [Header("Configuracion de Manzanas")]
    [Tooltip("Ingreso de objeto movimiento jugador")]
    [SerializeField] private MovimientoJugador movimientoJugador;
    [Tooltip("Ingreso de objeto gestor de estados")]
    [SerializeField] private GestorEstados estadoManzana;

    /// <summary>
    /// Se encarga de detectar manzanas comparandolo 
    /// con la etiqueta Manzana.Luego llama a la funcion manzana
    /// estado para aumentar su velocidad y lo destruye.
    /// </summary>
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.CompareTag("Manzana"))
        {
            movimientoJugador.velocidadAumento();
            estadoManzana.ManzanaEstado();
            Destroy(c.gameObject);
        }
    }
}
