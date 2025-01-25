using UnityEngine;

public class FinNivel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            NivelCompletado();
        }
    }

    private void NivelCompletado()
    {
        Debug.Log("¡Nivel Completado!");
        // Aquí puedes cargar la siguiente escena o mostrar un mensaje de victoria
    }
}
