using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad = 5;
    public string nombreDePool;
    private Pool pool;

    void OnEnable() {
        // POSIBLES ESTRATEGIAS DE DESTRUCCIÓN
        // - colisión con algún volumen
        // - deja de ser visible en el volumen de render
        // - por tiempo
        // - alguna lógica personalizada que aplique a algún tipo específico

        // Destroy(gameObject, 5);
        StartCoroutine(Deshabilitar());
    }

    void OnDisable() {

        // si se deshabilita por cualquier motivo detener corrutinas
        StopAllCoroutines();
    }

    void Start() {

        if(nombreDePool == null)
            throw new System.Exception("NOMBRE DE POOL NO ESPECIFICADO");

        pool = PoolIndex.Instance.ObtenerPool(nombreDePool);

        if(pool == null)
            throw new System.Exception("NOMBRE DE POOL NO VALIDO");
    }

    // Update is called once per frame
    void Update()
    {
        
        // Translate por default funciona con espacio local
        transform.Translate(0, 0, velocidad * Time.deltaTime, Space.World);    
    }

    void OnCollisionEnter(Collision c){
        
        pool.LeaveObject(gameObject);
    }

    IEnumerator Deshabilitar() {

        yield return new WaitForSeconds(5);
        pool.LeaveObject(gameObject);
    }
}
