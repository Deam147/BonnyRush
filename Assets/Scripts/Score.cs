using UnityEngine;
using UnityEngine.UI;//permite escribir codigo para los UI en Unity (textos)

public class Score : MonoBehaviour
{
    public LogicaPersonaje logicaPersonaje;
    public Transform player; // se referencia el jugador al slot de player desde Unity
    public Text scoreText;// Text referencia a los textos en Unity
    public Text carrotText;
    public Text coinText;

      public Text primerLugar;

      public string puntajePrimerLugar;
       public string nombrePrimerLugar;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = logicaPersonaje._points.ToString("0");
        carrotText.text = logicaPersonaje.carrotTxt.ToString("0");
        coinText.text = logicaPersonaje.coinTxt.ToString("0");

        PlayerPrefs.SetInt("Temp01",  logicaPersonaje._points);

        PlayerPrefs.SetString("NombreTemp01", "dfgfsdg");

        if ( PlayerPrefs.GetInt("Pos01", 0) < logicaPersonaje._points)
        {
            primerLugar.text = "You : " + logicaPersonaje._points;
        }
    }

    private void Start() {

        puntajePrimerLugar = PlayerPrefs.GetInt("Pos01", 0).ToString();
        nombrePrimerLugar = PlayerPrefs.GetString("Pos01Nombres", "UCR");
        primerLugar.text = nombrePrimerLugar+": " + puntajePrimerLugar;
        
    }

}
