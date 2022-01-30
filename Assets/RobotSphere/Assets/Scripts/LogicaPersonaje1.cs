using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje1 : MonoBehaviour
{
    public float velocidadMovimiento=5.0f;
    public float velocidadRotacion=200.0f;
    private Animator anim;
    public float x, y;
    // Start is called before the first frame update
    void Start()
    {
        anim= GetComponent<Animator>();//esta funcion nos devuelve los valore de nuestro personaje
                
    }

    // Update is called once per frame
    void Update()
    {//aqui pondremos las funciones para q nuestro personoje se mueva
        x=Input.GetAxis("Horizontal");//asegurarse que h este con mayuscula
        y=Input.GetAxis("Vertical");//asegurarse q v este con mayuscula

        transform.Rotate(0,x*Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y* Time.deltaTime * velocidadMovimiento);
        
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }
}
