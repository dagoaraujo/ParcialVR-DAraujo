using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaControlador : MonoBehaviour
{
    public Animator PuertaAnimator;

    private bool estaAbierta = false;

    public void InteractuarConPuerta()
    {
        if (!estaAbierta)
        {
            AbrirPuerta();
        }
        else
        {
            CerrarPuerta();
        }
    }

    [ContextMenu("Abrir Puerta")]
    public void AbrirPuerta()
    {
        print("puerta abierta");
        PuertaAnimator.SetBool("Abierta", true);

        estaAbierta = true;
    }
    [ContextMenu("Cerrar Puerta")]
    public void CerrarPuerta()
    {
        print("puerta cerrada");
        PuertaAnimator.SetBool("Abierta", false);

        estaAbierta = false;
    }
    [ContextMenu("Bloquear Puerta")]
    public void PuertaBloqueada()
    {
        print("puerta bloqueada");
    }
}