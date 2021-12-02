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

    public Timer timer;
    public float currentTime = 0f;
    public float startingTime = 12f;

     [SerializeField] float spawnPieces = 4f; 

     public int conteo = 1;

    
    // Start is called before the first frame update
    void Start()
    {
        GenerateCity();
      //  GenerateObstacles();
       currentTime = startingTime;
        Invoke("aumentarVelocidad",95.99f);
    }

    // Update is called once per frame
    void Update()
    {
        city.Translate(Vector3.back * citySpeed * Time.deltaTime); 

        Debug.Log("timer:"+currentTime);
        currentTime -= 1 * Time.deltaTime;

        if (currentTime <= 0 )
        {
            currentTime = startingTime;
        }  

            
    }

    void GenerateCity()
    {
        lastPiece = cityPiece;

        Invoke("GenerateCity", spawnPieces);

        cityPiece = cityPieces[Random.Range(0, cityPieces.Count)];
        cityPiece.position = new Vector3(0, 0, lastPiece.position.z + 40);
        cityPiece.gameObject.SetActive(true);
        cityPiece.SetParent(city);
        cityPieces.Remove(cityPiece);
        Debug.Log(" se genero una pieza");

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

    public void aumentarVelocidad(){

        if (conteo == 1)
        {
            citySpeed = 11f;
            spawnPieces = 3.6f;

        }else if(conteo == 2){
            citySpeed = 12f;
            spawnPieces = 3.3f;

        }else if(conteo == 3){
            citySpeed = 13f;
            spawnPieces = 3f;

        }else if(conteo == 4){
            citySpeed = 14f;
            spawnPieces = 2.7f;

        }else if(conteo == 5){
            citySpeed = 15f;
            spawnPieces = 2.55f;
        }
         conteo++; 
         if (conteo <= 5)
         {
             Invoke("aumentarVelocidad",95.99f); 
         }
          
    }
}
