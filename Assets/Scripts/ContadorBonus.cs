/// <summary>
/// Se encarga de contar bonus.
/// Luego sumar los puntos acumulados al contador 
/// para restarlo antes de que llegue al tiempo limite.
/// </summary>

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContadorBonus : MonoBehaviour
{
    
    [Header("Configuracion de contador bonus")]
    [Tooltip("Cantidad de tiempo limite del juego.")]
    [SerializeField] private float TiempoLimite;
    [Tooltip("Objeto estado del Juego.")]
    [SerializeField] private GestorJuego estadoJuego;
    /// <summary>contador de tiempo</summary>
    private float contador;
    /// <summary>variable de objeto de el TextMeshProGUI</summary>
    private TextMeshProUGUI textMesh;
    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        contador = 0;
        
    }
    /// <summary>
    /// Se encarga de sumar uno a uno segun cada frame.
    /// Convierte en String.
    /// </summary>
    private void Update()
    {
        contador += Time.deltaTime;
        if (contador < 0) contador = 0;
        if (textMesh != null)
        {
            textMesh.text = contador.ToString("0");
        }
        Limite();
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
    /// <summary>
    /// Se encarga de detectar si el contador llego al 
    /// tiempo limite. Luego envia un mensaje al
    /// estado del juego en caso sea verdadero.
    /// </summary>
    public void Limite()
    {
        if (contador>=TiempoLimite) {
            estadoJuego.JuegoPerdido(true);
        }
    }

}
