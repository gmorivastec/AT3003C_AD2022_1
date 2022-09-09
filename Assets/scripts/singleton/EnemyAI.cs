using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    // scope - alcance de una variable
    private GameObject personaje;

    // Start is called before the first frame update
    void Start()
    {

        // caso común
        // necesidad de obtener una referencia a un game object que está en escena
        

        // 2 pasos para cualquier variable 
        // declaración - definimos a nivel código que EXISTE!
        // asignación - guardamos valor en variable

        // 2 tipos de valor que podemos guardar
        // 1 - primitivos
        // 2- referencias

        // las referencias pueden (y de hecho inicialmente) ser nulos
        //personaje = GameObject.Find("PersonajePrincipal");
    }

    // Update is called once per frame
    void Update()
    {
        
        // trasladar un objeto 
        // transformaciones - (tema de gráficas)
        
        // cada objeto de tipo MonoBehaviour tiene referencia a 
        // otro objeto transform del mismo game object

        // aunque pongamos valor constante la velocidad no va a ser
        // nota para el futuro - multiplicar por Time.deltaTime
        // personaje.transform.Translate(1 * Time.deltaTime, 0, 0);
        Singleton.Instance.transform.Translate(1 * Time.deltaTime, 0, 0);
    }
}
