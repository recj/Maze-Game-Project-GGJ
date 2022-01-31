using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BotonMenu : MonoBehaviour
{
    // Start is called before the first frame update
     private void OnEnable()
    {//esto se activa cuando interectuamos con el objeto
        Time.timeScale = 0f;
    }

    private void OnDisable()
    {//cuando se desactive el objeto , se ejecuta este metodo
        Time.timeScale = 1f;
    }
}