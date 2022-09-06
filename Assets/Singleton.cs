using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// clase - 
// definición de un tipo 
// el tipo en este caso es un comportamiento

// Unity utiliza el paradigma de agregado

// de cada clase se crean objetos
// los objetos son instancias

// singleton - 
// - https://en.wikipedia.org/wiki/Singleton_pattern

public class Singleton : MonoBehaviour
{

    // properties
    // - mecanismo que declara una variable
    // y te permite definir quién lee y quién escribe

    // static -
    // - miembros que pertenecen directamente a la clase 
    // y no a una instancia
    public static Singleton Instance {
        private set;
        get;
    } 

     


    // Start is called before the first frame update
    void Start()
    {
        
        // SINGLETON SE TRATA DE TENER SÓLO 1 INSTANCIA DE UN TIPO ESPECÍFICO
        // normalmente esto se logra limitando el constructor 
        // (osea, no permitiendo que haya más de uno creado)

        // aquí vamos a destruir.
        if(Instance != null){

            // si entramos aquí es que ya se asigno
            // si es asi destruye este objeto
            Destroy(gameObject);
        } else {

            // necesitamos guardar este en la instance
            Instance = this;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
