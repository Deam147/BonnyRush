using UnityEngine;

public class LogicaPies : MonoBehaviour

{

    public LogicaPersonaje logicaPersonaje;

    private void OnTriggerStay(Collider other) {// si hay algo tocando el personaje puede saltar
        
        logicaPersonaje.saltando = true;

    }

    private void OnTriggerExit(Collider other) {// si no hay nada tocando el personaje no se puede saltar
        
        logicaPersonaje.saltando = false;
        
    }
}
