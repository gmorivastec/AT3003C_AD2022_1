using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
    public float velocidad = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Translate por default funciona con espacio local
        transform.Translate(0, 0, velocidad * Time.deltaTime, Space.World);    
    }
}
