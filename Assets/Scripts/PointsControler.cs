
using UnityEngine;

public class PointsControler : MonoBehaviour
{

    public LogicaPersonaje logicaPersonaje;
   
      private void OnTriggerEnter(Collider other) {
          
          if (other.CompareTag("Player"))
          {
              Destroy(gameObject);
          }
      }  
    
    
}
