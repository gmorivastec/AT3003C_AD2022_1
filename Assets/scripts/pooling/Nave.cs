using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{

    public float velocidad = 5;
    public GameObject balaOriginal;

    public Coroutine corrutinaDisparo;

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
        float v = Input.GetAxis("Vertical");

        transform.Translate(h * velocidad * Time.deltaTime, 0, v * velocidad * Time.deltaTime);

        // usar el axis 
        if(Input.GetKeyDown(KeyCode.Space)){
            corrutinaDisparo = StartCoroutine(Disparo());
        }

        if(Input.GetKeyUp(KeyCode.Space)){
            StopCoroutine(corrutinaDisparo);
        }
    }

    // corrutina de disparo
    IEnumerator Disparo() {

        // ciclo infinito!!! 
        // en cualquier otro contexto no debe ser utilizado
        while(true){

            // Instantiate(balaOriginal, transform.position, balaOriginal.transform.rotation);
            // regla general con instanciado
            // - si creamos objetos dinámicamente necesitamos una estrategia para destruirlos

            ProjectilePool.Instance.GetObject(transform.position);
            yield return new WaitForSeconds(0.75f);
        }
    }
}
