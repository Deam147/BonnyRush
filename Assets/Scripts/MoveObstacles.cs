using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacles : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] int health = 10;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Autodestruction", health);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void Autodestruction()
    {
        Destroy(gameObject);
    }
}
