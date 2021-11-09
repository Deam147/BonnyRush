using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{

   
    public void LoadNextLevel(){

        //puede ser llamada por nomombre o por build index (build setting) + 1 para cargar el siguiente nivel en la lista al ser llamado
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


}
