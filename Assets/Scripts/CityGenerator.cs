using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityGenerator : MonoBehaviour
{

    [SerializeField] Transform city;
    [SerializeField] float citySpeed;

    [SerializeField] List<Transform> cityPieces;
    [SerializeField] Transform cityPiece;

    Transform lastPiece;

    [SerializeField] List<Transform> obstaclesPieces;

    // Start is called before the first frame update
    void Start()
    {
        GenerateCity();
      //  GenerateObstacles();

    }

    // Update is called once per frame
    void Update()
    {
        city.Translate(Vector3.back * citySpeed * Time.deltaTime);
    }

    void GenerateCity()
    {
        lastPiece = cityPiece;

        cityPiece = cityPieces[Random.Range(0, cityPieces.Count)];
        cityPiece.position = new Vector3(0, 0, lastPiece.position.z + 40);
        cityPiece.gameObject.SetActive(true);
        cityPiece.SetParent(city);
        cityPieces.Remove(cityPiece);
        Debug.Log(" se genero una pieza");

        Invoke("GenerateCity", 4f);

    }

    void GenerateObstacles()
    {
        Transform obstaclesPiece = obstaclesPieces [Random.Range(0, obstaclesPieces.Count)];

        obstaclesPiece.position = Vector3.forward * 80; 
        obstaclesPiece.gameObject.SetActive(true);
        obstaclesPiece.SetParent(city);

        obstaclesPieces.Remove(obstaclesPiece);

        Invoke("GenerateObstacles", 6);

    }

    private void OnTriggerEnter(Collider coll)
    {
        Transform t = coll.GetComponent<Transform>();
        t.SetParent(null);
        
        cityPieces.Add(t);
        Debug.Log(t + " se anadio");


        coll.gameObject.SetActive(false);
    }
}
