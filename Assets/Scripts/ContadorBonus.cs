/// <summary>
/// Se encarga de contar bonus.
/// Luego sumar los puntos acumulados al contador 
/// para restarlo antes de que llegue al tiempo limite.
/// </summary>

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorBonus : MonoBehaviour
{
    /// <summary>contador de tiempo</summary>
    private float contador;
    private TextMeshProUGUI textMesh;

    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }
    /// <summary>
    /// Se encarga de sumar uno a uno segun cada frame.
    /// Convierte en String.
    /// </summary>
    private void Update()
    {
        contador += Time.deltaTime;
        textMesh.text = contador.ToString("0");
    }
    /// <summary>
    /// Se encarga de recibir bonus.
    /// Luego restar al acumulador de tiempo antes
    /// de que llegue a tiempo limite.
    /// </summary>
    public void SumarPuntos(float puntoEntrada) 
    {
        contador -= puntoEntrada;
    }
}
