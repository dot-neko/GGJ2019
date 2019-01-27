using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinJuego : MonoBehaviour
{
    public AudioSource Sound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Sound.Play();
        Invoke("Final", 3.0f);
    }
    public void Final()
    {
        SceneManager.LoadScene("FinJuego");
    }
}
