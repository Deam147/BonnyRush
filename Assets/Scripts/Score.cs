using UnityEngine;
using UnityEngine.UI;//permite escribir codigo para los UI en Unity (textos)

public class Score : MonoBehaviour
{
    public LogicaPersonaje logicaPersonaje;
    public Transform player; // se referencia el jugador al slot de player desde Unity
    public Text scoreText;// Text referencia a los textos en Unity

    // Update is called once per frame
    void Update()
    {
        scoreText.text = logicaPersonaje.points.ToString("0");
    }

}
