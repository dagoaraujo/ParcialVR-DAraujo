using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    public AudioSource audioAmbiente;
    public AudioSource audioRecogida;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            Recoger();
        }
    }

    void Recoger()
    {

        if (audioAmbiente != null)
        {
            audioAmbiente.Stop();
        }


        if (audioRecogida != null && audioRecogida.clip != null)
        {
            AudioSource.PlayClipAtPoint(audioRecogida.clip, transform.position);
        }


        Destroy(gameObject);
    }
}