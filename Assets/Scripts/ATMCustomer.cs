using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
public class ATMCustomer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ReadLines();
    }
    void ReadLines()
    {
        string[] ATMcustomers = System.IO.File.ReadAllLines(@"Assets/Scripts/G4_NatVicGuiGurKau_Project_1_Generated_Data.txt");
        foreach (string line in ATMcustomers)
        {
            Debug.Log('\n' + line);
        }
    }
}
