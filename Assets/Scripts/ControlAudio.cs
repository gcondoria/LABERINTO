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
    /// con las teclas P,U.
    /// </summary>
    void Update()
    {
    
        if (Input.GetKeyDown(KeyCode.P))
        {
            audioSource.Pause();
            Time.timeScale = 0f;
            Debug.Log("Audio pausado.");
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            audioSource.UnPause();
            Time.timeScale = 1f;
            Debug.Log("Audio despausado.");
        }
    }
}
