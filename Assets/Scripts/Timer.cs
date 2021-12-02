using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

   public CityGenerator cityGenerator;
    [SerializeField] Text timerTxt;
    public float currentTime = 0f;
    public float startingTime = 96f;

    [SerializeField] Text velocidadTxt;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
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
        
       velocidadTxt.text = "Velocidad: " + cityGenerator.conteo.ToString();

    }
   
}

