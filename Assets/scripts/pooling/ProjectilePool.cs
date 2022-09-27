using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// lo que estamos haciendo aquí se llama herencia
// estamos definiendo un subtipo de un tipo que ya habíamos definido
public class ProjectilePool : Pool
{

    // si lo dejamos en la superclase va a checar todos los que sean pool
    public static ProjectilePool Instance {
        get;
        private set;
    }

    public void Start() {

        // verificación del singleton
        if(Instance != null){
            Destroy(gameObject);
        } else {
            Instance = this;
        }
    }
}
