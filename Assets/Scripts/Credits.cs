using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
   
    public void Quit(){//agrega un evento de boton

    Debug.Log("QUIT");
    Application.Quit();// sale de la app

    }

    public void GotoMenu(){

        SceneManager.LoadScene("Menu");

    }

}
