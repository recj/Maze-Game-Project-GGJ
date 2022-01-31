using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionsWithPlayer : MonoBehaviour
{
    public Inventario inventario;//llamando al inventario
    // Start is called before the first frame update
    void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
    }

    private void OnTriggerEnter(Collider other){
        //si entra en esta funcion ,hara contacto directo con el objeto
        //el other es el objeto q esta colisionando
        if(other.tag == "Player")//Player es un tag que viene por defecto en unity
        {
            inventario.cantidad = inventario.cantidad +1;
        // barraVida.vidaActual= barraVida.vidaActual -20;
            Destroy(gameObject);

        }


        }
}
