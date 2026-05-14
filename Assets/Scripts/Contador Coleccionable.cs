using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorColeccionable : MonoBehaviour
{
    public TextMeshProUGUI TextoContador;
    public int TotalColeccionable = 0;

    [ContextMenu("Aumentar Contador")]
    public void AumentarContador()
    {
        TotalColeccionable ++ ;
        TextoContador.text = TotalColeccionable.ToString();
    }

    private void OnEnable()
    {
        SujetoObservableControlador.IncrementarContadorColeccionable += AumentarContador;
    }

    private void OnDisable()
    {
        SujetoObservableControlador.IncrementarContadorColeccionable -= AumentarContador;
    }
}
