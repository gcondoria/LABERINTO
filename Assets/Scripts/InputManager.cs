/// <summary>
/// Lee el movimiento físico del personaje.
/// Y retorna los datos leidos.
/// </summary>

using UnityEngine;

public class InputManager : MonoBehaviour
{
    /// <summary>Retorna datos del movimiento en Vertical.</summary>
    public float MovimientoVertical { get; private set; }
    /// <summary>Retorna datos del movimiento en Horizontal.</summary>
    public float MovimientoHorizontal { get; private set; }

    /// <summary>
    /// Lee el movimiento físico del personaje ya sea Vertical u Horizontal.
    /// </summary>
    void Update()
    {
        MovimientoVertical = Input.GetAxis("Vertical");
        MovimientoHorizontal = Input.GetAxis("Horizontal");
    }
}