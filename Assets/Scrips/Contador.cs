using TMPro; // Asegúrate de tener esto si usas TextMeshPro
using UnityEngine;

public class Contador : MonoBehaviour
{
    public int monedas = 0;
    public TextMeshProUGUI texto; // Asigna esto desde el Inspector

    public void AgregarMoneda()
    {
        monedas++;
        ActualizarTexto();
    }

    public void ActualizarTexto()
    {
        if (texto != null)
            texto.text = "Coins: " + monedas;
    }
}
