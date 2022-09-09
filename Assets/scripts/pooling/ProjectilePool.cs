using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePool : MonoBehaviour
{

    [SerializeField]
    private GameObject proyectilOriginal;
    
    [SerializeField]
    private int tamanioDePool;
    
    // queue???
    private Queue<GameObject> cola;

    public static ProjectilePool Instance {
        get;
        private set;
    }


    void Awake() {

        // verificación del singleton
        if(Instance != null){
            Destroy(gameObject);
        } else {
            Instance = this;
        }

        // lógica del pool

        // inicializar cola
        cola = new Queue<GameObject>();

        // hacer un ciclo tamanio veces
        // for - estructura de control de flujo
        for(int i = 0; i < tamanioDePool; i++){

            //print(i);
            // crear nuevo objeto
            GameObject nuevo = Instantiate<GameObject>(proyectilOriginal);

            // deshabilitarlo 
            nuevo.SetActive(false);

            // agregar al objeto recién creado a la cola
            cola.Enqueue(nuevo);

        }

    }

    public GameObject GetProjectile(Vector3 position){

        if(cola.Count == 0)
            return null;

        // obtener el siguiente en la fila
        GameObject siguiente = cola.Dequeue();

        siguiente.SetActive(true);
        siguiente.transform.position = position;
        siguiente.transform.rotation = proyectilOriginal.transform.rotation;

        return siguiente;
    }

    public void LeaveProjectile(GameObject projectile){


        // desactivar
        projectile.SetActive(false);
        cola.Enqueue(projectile);
    }
}
