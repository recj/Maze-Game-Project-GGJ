using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateTextCounter : MonoBehaviour
{
    public Text contadorText;
    public Inventario inventario;//llamando al inventario
    // Start is called before the first frame update
    void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
    }

    // Update is called once per frame
    void Update()
    {
        contadorText.text = "Minerales: " + inventario.cantidad.ToString() + "/10";
        
    }
}
