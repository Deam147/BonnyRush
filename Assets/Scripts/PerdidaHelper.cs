using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PerdidaHelper : MonoBehaviour
{
    public CambiarScena cambio;

    public Text PuntajeTotal;
    public InputField PuntajeNombre;

    public string nomPubtaje;

    public int[] puntajes;
    public string[] puntajesNombres;

    private int pivote;
    private int temp;
    private string pivoteNombre;
    private string tempNom;

    public void GuardarDatosDiscoDuro()
    {
        puntajes = new int[3];
        puntajesNombres = new string[3];

        RecuperarDatos();

        //pivote = ;

        if (pivote > puntajes[0]) ;
        {
            temp = puntajes[1];
            tempNom = puntajesNombres[1];

            puntajes[1] = puntajes[0];
            puntajesNombres[1] = puntajesNombres[0];

            puntajes[0] = pivote;
            puntajesNombres[0] = pivoteNombre;

            pivote = temp;
            pivoteNombre = tempNom;
        }
        if (pivote > puntajes[1]) ;
        {

            temp = puntajes[2];
            tempNom = puntajesNombres[2];

            puntajes[2] = puntajes[1];
            puntajesNombres[2] = puntajesNombres[1];

            puntajes[1] = pivote;
            puntajesNombres[1] = pivoteNombre;

            pivote = temp;
            pivoteNombre = tempNom;

            
        }
        if (pivote > puntajes[2]) ;
        {

            puntajes[2] = pivote;
            puntajesNombres[2] = pivoteNombre;

        }

        

        GuardarDatos();

    }
    private void Start()
    {
       
        //PuntajeTotal.text

    }

    private void RecuperarDatos()
    {
        puntajes[0] = PlayerPrefs.GetInt("Pos01",0);
        puntajes[1] = PlayerPrefs.GetInt("Pos02",0);
        puntajes[2] = PlayerPrefs.GetInt("Pos03",0);


        puntajesNombres[0] = PlayerPrefs.GetString("PosNombres01",nomPubtaje);
        puntajesNombres[1] = PlayerPrefs.GetString("PosNombres02", nomPubtaje);
        puntajesNombres[2] = PlayerPrefs.GetString("PosNombres03", nomPubtaje); 

    }

    private void GuardarDatos()
    {
        PlayerPrefs.SetInt("Pos01", puntajes[0]);
        PlayerPrefs.SetInt("Pos02", puntajes[1]);
        PlayerPrefs.SetInt("Pos03", puntajes[2]);

        PlayerPrefs.SetString("PosNombres01", puntajesNombres[0]);
        PlayerPrefs.SetString("PosNombres02", puntajesNombres[1]);
        PlayerPrefs.SetString("PosNombres03", puntajesNombres[2]);
    }

    public void VolverMenu()
    {
        pivoteNombre = PuntajeNombre.text;
        GuardarDatosDiscoDuro();
        cambio.CambiarScenaClik("PantallaInicial");
    }

    public void Puntuaciones()
    {
        pivoteNombre = PuntajeNombre.text;
        GuardarDatosDiscoDuro();
        cambio.CambiarScenaClik("Puntuaciones");
    }

    public void Salir()
    {
        pivoteNombre = PuntajeNombre.text;
        GuardarDatosDiscoDuro();
        cambio.SalirJuego();
    }
}
