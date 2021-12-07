using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PerdidaHelper : MonoBehaviour
{
    public string EscenaPortada;
    public Text PuntajeTotal;
    public InputField inicialesJugador;

    public int[] puntajes;
    public string[] puntajesNombres;

    private int pivote;
    private int temp;
    private string pivoteNombre;
    private string tempNombre;

    LogicaPersonaje logicaPersonaje;


    public void GuardarDatosClick(string pivoteNombre)
    {
        puntajes = new int[3];
        puntajesNombres = new string[3];
        RecuperarDatos();

        pivote = PlayerPrefs.GetInt("Temp01", 0);

        if (pivote > puntajes[0])
        {
            tempNombre = puntajesNombres[1];
            temp = puntajes[1];

            puntajes[1] = puntajes[0];
            puntajes[0] = pivote;
            Debug.Log(pivoteNombre + puntajesNombres[0] + puntajesNombres[1]);
            puntajesNombres[1] = puntajesNombres[0];
            puntajesNombres[0] = pivoteNombre;


            pivoteNombre = tempNombre;
            pivote = temp;
        }
        if (pivote > puntajes[1])
        {
            temp = puntajes[2];
            tempNombre = puntajesNombres[2];

            puntajesNombres[2] = puntajesNombres[1];
            puntajesNombres[1] = pivoteNombre;

            puntajes[2] = puntajes[1];
            puntajes[1] = pivote;


            pivoteNombre = tempNombre;


            pivote = temp;
        }
        if (pivote > puntajes[2])
        {
            puntajes[2] = pivote;
            puntajesNombres[2] = pivoteNombre;

        }

        Debug.Log(pivoteNombre + puntajesNombres[0] + puntajesNombres[1]+"Nombres");
        GuardarDatos();
    }
    private void Start()
    {
        

        
        //PuntajeTotal.text = LogicaPersonaje.instancia.ObtenerPuntaje().ToString();
        PuntajeTotal.text = PlayerPrefs.GetInt("Temp01", 0).ToString();

       
    }

    private void RecuperarDatos()
    {
        puntajes[0] = PlayerPrefs.GetInt("Pos01", 0);
        puntajes[1] = PlayerPrefs.GetInt("Pos02", 0);
        puntajes[2] = PlayerPrefs.GetInt("Pos03", 0);

        puntajesNombres[0] = PlayerPrefs.GetString("Pos01Nombres", "UCR");
        puntajesNombres[1] = PlayerPrefs.GetString("Pos02Nombres", "UCR");
        puntajesNombres[2] = PlayerPrefs.GetString("Pos03Nombres", "UCR");

    }

    private void GuardarDatos()
    {
        PlayerPrefs.SetInt("Pos01", puntajes[0]);
        PlayerPrefs.SetInt("Pos02", puntajes[1]);
        PlayerPrefs.SetInt("Pos03", puntajes[2]);

        PlayerPrefs.SetString("Pos01Nombres", puntajesNombres[0]);
        PlayerPrefs.SetString("Pos02Nombres", puntajesNombres[1]);
        PlayerPrefs.SetString("Pos03Nombres", puntajesNombres[2]);

        Debug.Log("Guardando");
    }

    public void VolverPortada()
    {

        pivoteNombre= inicialesJugador.text;
        GuardarDatosClick(pivoteNombre);

        try
        {
            CambiarEscena(EscenaPortada);

        }
        catch (System.Exception)
        {
            Debug.Log("Se te olvido poner el GameManager en la escena");
        }
    }

     public void VolverPuntajes()
    {

        pivoteNombre= inicialesJugador.text;
        GuardarDatosClick(pivoteNombre);

        try
        {
            CambiarEscena("Puntuaciones");

        }
        catch (System.Exception)
        {
            Debug.Log("Se te olvido poner el GameManager en la escena");
        }
    }

    public void CambiarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}