using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorColeccionables : MonoBehaviour
{
    private int cantidadRecolectada = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coleccionable"))
        {
            cantidadRecolectada++;
            Debug.Log("¡Laptop recolectada! Total: " + cantidadRecolectada);
            
            Destroy(other.gameObject);
        }
    }
}