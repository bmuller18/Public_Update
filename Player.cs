using UnityEngine;

public class Player : MonoBehaviour
{
    public const int ORO_INICIAL = 100;
    private int oroActual = ORO_INICIAL;

    // Función que se llama cuando el jugador se repara
    public void Reparar()
    {
        const int COSTO_REPARACION = 25;
        if (oroActual >= COSTO_REPARACION)
        {
            oroActual -= COSTO_REPARACION;
            Debug.Log($"Has gastado {COSTO_REPARACION} monedas de oro en reparaciones. Te quedan {oroActual} monedas de oro.");
            return;
        }
        
        Debug.Log("No tienes suficientes monedas de oro para reparaciones.");
    }
}