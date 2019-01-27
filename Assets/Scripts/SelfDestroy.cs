using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    private AudioSource Sound;

    private void Start()
    {
        Sound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Sound.Play();
        Destroy(gameObject, 0.2f);
    }
}
