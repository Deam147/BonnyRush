using UnityEngine;
using UnityEngine.SceneManagement;// para manejar las escenas
using UnityEngine.UI;

public class GameManager : MonoBehaviour{

    bool gameHasEnded = false; 

    public GameObject completeLevelUI; //acceder al Ui del panel

    public float restartDelay = 1f;

    public void CompleteLevel(){

      completeLevelUI.SetActive(true);//habilita el panel de gane
    }

    public void EndGame(){

       if (gameHasEnded == false)// al llamar falso + falso = verdadero
       {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Restart();
            Invoke("Restart", restartDelay); //llama un metodo. nombre del metodo(String) y 
            //despues cuanto tarda en ejecutar en segundos(float)
       }

       void Restart(){

           SceneManager.LoadScene(SceneManager.GetActiveScene().name);//carga la escena que este activa
       }

   }


   public LogicaPersonaje logicaPersonaje;
    public Transform player; // se referencia el jugador al slot de player desde Unity
    public Text scoreText;// Text referencia a los textos en Unity
    public Text carrotText;
    public Text coinText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = logicaPersonaje._points.ToString("0");
        carrotText.text = logicaPersonaje.carrotTxt.ToString("0");
        coinText.text = logicaPersonaje.coinTxt.ToString("0");
    }


}
