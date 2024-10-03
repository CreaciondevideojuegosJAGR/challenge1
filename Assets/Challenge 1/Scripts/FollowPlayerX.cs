using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Autor: José Armando Gutiérrez Rodríguez
 * Fecha: 01/10/2024
 * Challenge 1, Create With Code
 * **/

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(30, 0, 10);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
