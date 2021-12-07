using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

   public CityGenerator cityGenerator;

   public int conteo = 1;
    [SerializeField] Text timerTxt;
    public float currentTime = 0f;
    public float startingTime = 96f;

    [SerializeField] Text velocidadTxt;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
         Invoke("aumentarVelocidad",95.99f);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        string minSec = string.Format("{0}:{1:00}", (int)currentTime / 60, (int)currentTime % 60); timerTxt.text = minSec;

        if (currentTime <= 0 )
        {
            currentTime = startingTime;
        } 
        
       velocidadTxt.text = "Vel: " + conteo.ToString();

    }

     public void aumentarVelocidad(){
 
         conteo++; 
         if (conteo <= 5)
         {
             Invoke("aumentarVelocidad",95.99f); 
         }
         
    }
   
}

