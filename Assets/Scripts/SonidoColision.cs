/// <summary>
/// Se encarga de detectar choques.
/// Luego generar sonido de colicion choque.
/// </summary>

using UnityEngine;
//[RequireComponent(typeof(Rigidbody))]
public class SonidoColision : MonoBehaviour
{
    /// <summary>Configuracion de sonido.</summary>
    [Header("Configuracion sonido colision")]
    [Tooltip("volumen de musica.")]
    public float volumen = 1f;
    [Tooltip("ingreso de musica.")]
    [SerializeField] private AudioClip sonidoC;
    private AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.volume = volumen;
    }
    /// <summary>
    /// Se encarga de detectar choques.
    /// Luego generar sonido de colicion choque.
    /// </summary>
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.CompareTag("Jugador"))
        {
            audio.PlayOneShot(sonidoC);
        }

    }
}
