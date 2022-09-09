using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{

    public float velocidad = 5;
    public GameObject balaOriginal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Update tratamos que tenga 2 cosas únicamente
    // 1. movimiento
    // 2. detección de input 
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        
        transform.Translate(h * velocidad * Time.deltaTime, 0, 0);
    }
}
