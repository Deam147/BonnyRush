
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicaPersonaje : MonoBehaviour
{

    public float velocidadMovimiento = 5.0f;
     public float forwardForce = 200f;

    public float velocidadRotacion = 200f;
    public float x,y,z;//nos permite saber si el jugador se mueve

    public Rigidbody rb; 
    public float fuerzaSalto = 8f;
    public float fuerzaBajar = 1f;
    public float sideWaysForce = 500f;
    public bool saltando;

    public int carrot = 0;
    public int carrotTxt = 0;
    public int coin = 0;
    public int coinTxt = 0;
    public int _points = 0;

    private Animator anim;// accede al componenten de la animacion


    void Start()
    {
        saltando = false;
        anim = GetComponent<Animator>();//Saca los valores del componente animator

    }

    
    void FixedUpdate() { // estandariza la velocidad de los frames en las pc
        
        //transform.Translate(0, x * Time.deltaTime * forwardForce, 0);//le permite rotar en el eje x
        //transform.Translate(0,0, y * Time.deltaTime * forwardForce);// permite desplazarse en el eje y 


         //MOVER DERECHA
        if (Input.GetKey("d"))
        {
           rb.AddForce(sideWaysForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        //MOVER IZQUIERDA
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }



         if (rb.position.y < -1f)
        {
           SceneManager.LoadScene("Perdida");
        }
    }

    void Update() {
        
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        if (saltando)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("Saltar", true);// activa la animacion de salto
                rb.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode.Impulse);// se agrega fuerza de impulso al eje Y
            }
            ;
            rb.AddForce(new Vector3(0, -fuerzaBajar, 0));
            anim.SetBool("TocarSuelo", true);//activa la animacion estandar
        }else
        {
            EstoyCayendo();
        }

       sumarPuntos();

    } 

    public void EstoyCayendo(){

        anim.SetBool("TocarSuelo", false); 
        anim.SetBool("Saltar", false);
    }

     private void OnTriggerEnter(Collider other) {
          
          if (other.CompareTag("Carrot"))
          {
              Debug.Log("Ganaste 5 puntos"); 
              carrot = carrot + 5; 
              carrotTxt++;
            
          }

           if (other.CompareTag("Coin"))
          {
              Debug.Log("Ganaste 50 puntos");
              coin = coin + 50;  
              coinTxt++;
          }

            if (other.CompareTag("Obstacle"))
          {
              SceneManager.LoadScene("Perdida");
          }
      }  

    public void sumarPuntos(){

        _points = carrot + coin;

    }


    //Singelton
    private static LogicaPersonaje _instancia;
    public static LogicaPersonaje instancia
    {
        get
        {
            return _instancia;
        }
    }
    //Miembros de clase privados

    public int ObtenerPuntaje()
    {
        return _points;
    }

   
}