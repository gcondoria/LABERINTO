/// <summary>
/// Se encarga de detectar bonus.
/// Luego sumar los puntos acumulados.
/// </summary>

using UnityEngine;
//[RequireComponent(typeof(Rigidbody))]
public class DeteccionBonus : MonoBehaviour
{
    /// <summary>Configura los puntos acumulados.</summary>
    [Header("Configuracion de bonus")]
    [Tooltip("cantidad de puntos a restar al contador de tiempo.")]
    [SerializeField] private float CantidadPuntos;
    [Tooltip("ingreso de contador de tiempo.")]
    [SerializeField] private ContadorBonus contador ;
    [Tooltip("ingreso de gestor de estado del Bonus.")]
    [SerializeField] private GestorEstados estadoBonus;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Se encarga de detectar bonus comparandolo con la etiqueta Punto.
    /// Luego sumar los puntos acumulados al contador y destruye el objeto chocado.
    /// </summary>
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.CompareTag("Punto"))
        {
            contador.SumarPuntos(CantidadPuntos);
            estadoBonus.BonusEstado();
            Destroy(c.gameObject);
        }

    }
}
