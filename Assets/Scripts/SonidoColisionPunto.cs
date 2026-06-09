/// <summary>
/// Se encarga de detectar bonus.
/// Luego generar sonido de colicion bonus.
/// </summary>

using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class SonidoColisionPunto : MonoBehaviour
{
    /// <summary>Configuracion de sonido.</summary>
    [Header("Configuracion sonido bonus")]
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
    /// Se encarga de detectar bonus.
    /// Luego generar sonido de colicion bonus.
    /// </summary>
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.CompareTag("Punto"))
        {
            audio.PlayOneShot(sonidoPuntos);
        }

    }
}
