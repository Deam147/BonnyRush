using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement2 : MonoBehaviour
{
    public Rigidbody rb;

    // variables para la fuerza y poder editarla en Unitypublic float forwardForce = 2000f;
    //public float sideWaysForce = 500f;


    // Update is called once per frame
    void FixedUpdate() //Se usa FixedUpdate cuando se calculan fisicas
    {
        //MOVER DELANTE
        //rb.AddForce(0,0,forwardForce * Time.deltaTime);// Time.deltaTime hace que los frames actuan conforme al rendimiento del pc

        //MOVER DERECHA
        //if (Input.GetKey("d"))
        {
           // rb.AddForce(sideWaysForce * Time.deltaTime,0,0, ForceMode.VelocityChange);//cambia la velocidad sin contar 
            //ForcemMode.VelocityChange su masa
        }

        //MOVER IZQUIERDA
        //if (Input.GetKey("a"))
        {
            //rb.AddForce(-sideWaysForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        //if (rb.position.y < -1f)
        {
           //SceneManager.LoadScene("Menu");
        }
    }

   
}
