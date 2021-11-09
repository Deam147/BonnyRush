using UnityEngine;

public class EndTrigger : MonoBehaviour{
    

public GameManager gameManager;//permite referenciar un objeto

void OnTriggerEnter()
{
    
    gameManager.CompleteLevel();

}


}

