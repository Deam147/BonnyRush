using UnityEngine;
using UnityEngine.SceneManagement;// para manejar las escenas

public class GameManager : MonoBehaviour{
    bool gameHasEnded = false; 

    public GameObject completeLevelUI; //acceder al Ui del panel

    public LogicaPersonaje logicaPersonaje;
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

    
        

        
}
