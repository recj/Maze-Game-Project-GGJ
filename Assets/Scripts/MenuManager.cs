using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//usamos esta libreria
public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void BotonStart()
    {
        SceneManager.LoadScene("OnGame");//para cargar la escena
    }

    // Update is called once per frame
    public void BotonQuit()
    {
        Debug.Log("Gracias por jugar amigx <3");
        Application.Quit();//esta parte solo funcionara en el juego construido por la build,en el editor no da
    }
    // Update is called once per frame
    public void BotonGoMainManu()
    {
        SceneManager.LoadScene("OnMenu");//para cargar la escena
    }
}