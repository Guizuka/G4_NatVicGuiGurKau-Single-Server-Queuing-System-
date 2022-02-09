using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ProgGeneration : MonoBehaviour
{

    float mean = 4f;
    float stdDev = 1f;
   
    // Start is called before the first frame update
    void Start()
    {
        GenerateCustomers();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     

    private void FixedUpdate()
    {

        
    }

    private void GenerateCustomers()
    {
        Customer[] customers = new Customer[50];
        for (int i = 0; i < 50; i++)
        {
            customers[i] = new Customer();
            customers[i].sTime = GenerateNormalized(mean, stdDev);
            customers[i].aTime = GenerateNormalized(mean, stdDev);
            Debug.Log("Customer " + i + " Spent time: " + customers[i].sTime + " Arrival time: " + customers[i].aTime);
        }
    }



    private float GenerateNormalized(float mean, float stddev)
    {
        float var = stddev * stddev;
        System.Random rnd = new System.Random();
        double x = rnd.NextDouble();
        float one_over_2pi = (float)(1.0 /(stddev * Math.Sqrt(2 * Math.PI)));
        return (float)(one_over_2pi * Math.Exp(-(x - mean) * (x - mean) / (2 * var)));
    }
}


