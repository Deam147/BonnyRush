using UnityEngine;

public class PersonajeColision : MonoBehaviour
{
    public PlayerMovement movement;
    public LogicaPersonaje logica;

    void OnCollisionEnter(Collision collisionInfo){ // metodo para colisiones

    if (collisionInfo.collider.tag == "Obstacle")//busca por el tag creado en Unity para los obstaculos
    {
        movement.enabled = false; // se referencia el script de PlayerMovement arrastrandolo al slot de movement 
                                  //desde Unity
            logica.sumarPuntos();

        FindObjectOfType<GameManager>().EndGame();//busca un objeto tipo gameManager
            

     }
 }
}
