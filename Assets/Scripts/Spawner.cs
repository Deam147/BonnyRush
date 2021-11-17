using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float timeToSpawn = 1.5f;

    public List<GameObject> objectsPrefab;

    public int range;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }



    void Spawn()
    {
        range = Random.Range(0, objectsPrefab.Count);
        Instantiate(objectsPrefab[range],transform.position, transform.rotation);
        Invoke("Spawn", timeToSpawn);
    }
}
