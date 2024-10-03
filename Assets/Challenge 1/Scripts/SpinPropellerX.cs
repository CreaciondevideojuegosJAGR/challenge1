using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Autor: José Armando Gutiérrez Rodríguez
 * Fecha: 01/10/2024
 * Challenge 1, Create With Code
 * **/

public class SpinPropeller : MonoBehaviour
{
    private float propellorSpeed = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, propellorSpeed * Time.deltaTime);   
    }
}
