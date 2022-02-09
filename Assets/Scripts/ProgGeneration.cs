using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Customer
{
    public float sTime;
    public float aTime;
}

public class ProgGeneration : MonoBehaviour
{

    float mean = 1f;
    float stdDev = 0.1f;
    public Customer[] customers;
    // Start is called before the first frame update
    void Start()
    {
        customers = new Customer[50];
        //customers[0].sTime = GenerateNormalized(mean, stdDev);
        //customers[0].aTime = GenerateNormalized(mean, stdDev);
        Debug.Log("Customer" + "0" + "Spent time:" + customers[0].sTime + "Arrival time" + customers[0].aTime);
        //for (int i = 0; i < 50; i++)
        //{
        //    customers[0].sTime = GenerateNormalized(mean, stdDev);
        //    customers[0].aTime = GenerateNormalized(mean, stdDev);
        //    Debug.Log("Customer" + "0" + "Spent time:" + customers[0].sTime + "Arrival time" + customers[0].aTime);
       // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     

    private void FixedUpdate()
    {

        
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


