
using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{

    public float velocidadMovimiento = 5.0f;
     public float forwardForce = 2000f;

    public float velocidadRotacion = 200.0f;
    public float x,y,z;//nos permite saber si el jugador se mueve

    public Rigidbody rb; 
    public float fuerzaSalto = 8f;
    public float fuerzaBajar = 1f;
    public bool saltando;

    private Animator anim;// accede al componenten de la animacion


    void Start()
    {
        saltando = false;
        anim = GetComponent<Animator>();//Saca los valores del componente animator

    }

    
    void FixedUpdate() { // estandariza la velocidad de los frames en las pc
        
        transform.Rotate(0, x * Time.deltaTime * forwardForce*10, 0);//le permite rotar en el eje x
        transform.Translate(0,0, y * Time.deltaTime * forwardForce);// permite desplazarse en el eje y 

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

    } 

    public void EstoyCayendo(){

        anim.SetBool("TocarSuelo", false); 
        anim.SetBool("Saltar", false);
    }

}