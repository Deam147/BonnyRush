using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo){ // metodo para colisiones

    if (collisionInfo.collider.tag == "Obstacle")//busca por el tag creado en Unity para los obstaculos
    {
        movement.enabled = false; // se referencia el script de PlayerMovement arrastrandolo al slot de movement 
        //desde Unity

         SceneManager.LoadScene("Perdida");
    }
}


}
