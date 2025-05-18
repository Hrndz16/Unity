using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CambiaBala : MonoBehaviour
{
    public Move moveScript; // Referencia al script Move
    public TextMeshProUGUI texto;
    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");

        if (scroll != 0f) // Si la rueda se mueve en cualquier dirección
        {
            // Cambiamos el valor de cambiaObjeto a su inverso (true -> false, false -> true)
            moveScript.cambiaObjeto = !moveScript.cambiaObjeto;
            Debug.Log("Rueda hacia adelante");
            ActualizarTexto();
        }

    }
    public void ActualizarTexto()
    {
        if (!moveScript.cambiaObjeto)
        {
            texto.text = "Arma: Una Bala ";
        }
        else
        {
            texto.text = "Arma: Dos Balas ";
        }
    }
    
}
