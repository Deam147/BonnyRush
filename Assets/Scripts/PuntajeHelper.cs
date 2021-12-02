using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntajeHelper : MonoBehaviour
{
    public Text PrimerLugarPuntaje;
    public Text SegundoLugarPuntaje;
    public Text TercerLugarPuntaje;

    public Text PrimerLugarNombre;
    public Text SegundoLugarNombre;
    public Text TercerLugarNombre;


    // Start is called before the first frame update
    void Start()
    {
        PrimerLugarPuntaje.text = PlayerPrefs.GetInt("Pos01",0).ToString();
        PrimerLugarNombre.text = PlayerPrefs.GetString("PosNombres01","");

        SegundoLugarPuntaje.text = PlayerPrefs.GetInt("Pos02", 0).ToString();
        SegundoLugarNombre.text = PlayerPrefs.GetString("PosNombres02", "");

        TercerLugarPuntaje.text = PlayerPrefs.GetInt("Pos03", 0).ToString();
        TercerLugarNombre.text = PlayerPrefs.GetString("PosNombres03", "");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
