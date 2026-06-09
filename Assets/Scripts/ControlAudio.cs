/// <summary>
/// Se encarga de inicializar el audio musica general.
/// Incluye la manipulacion de configuracion a traves de botones.
/// </summary>

using UnityEngine;

public class ControlAudio : MonoBehaviour
{
    private AudioSource audioSource;
    /// <summary>Reproduce musica desde el inicio.</summary>
    private void Start()
    {
        audioSource.Play();
    }
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    /// <summary>
    /// Se encarga de manipukar el audio inicial a traves de botones
    /// con las teclas P,O,I,U.
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            audioSource.Play();
            Debug.Log("Reproduciendo: " + audioSource.clip.name);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            audioSource.Pause();
            Debug.Log("Audio pausado.");
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            audioSource.Stop();
            Debug.Log("Audio detenido.");
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            audioSource.UnPause();
            Debug.Log("Audio despausado.");
        }
    }

}
