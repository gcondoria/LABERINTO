/// <summary>
/// Se encarga de detectar Manzanas.
/// Luego generar sonido de colicion Manzana.
/// </summary>

using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class SonidoColisionManzana : MonoBehaviour
{
    /// <summary>Configuracion de sonido.</summary>
    [Header("Configuracion sonido manzana")]
    [Tooltip("volumen de musica.")]
    public float volumen = 0.8f;
    [Tooltip("ingreso de musica.")]
    [SerializeField] private AudioClip sonidoPuntos;
    private AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.volume = volumen;
    }
    /// <summary>
    /// Se encarga de detectar manzana.
    /// Luego generar sonido de colision manzana.
    /// </summary>
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.CompareTag("Manzana"))
        {
            audio.PlayOneShot(sonidoPuntos);
        }

    }
}
