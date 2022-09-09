using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
    public float velocidad = 5;

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

    // Update is called once per frame
    void Update()
    {
        // Translate por default funciona con espacio local
        transform.Translate(0, 0, velocidad * Time.deltaTime, Space.World);    
    }

    void OnCollisionEnter(Collision c){
        
        ProjectilePool.Instance.LeaveProjectile(gameObject);
    }

    IEnumerator Deshabilitar() {

        yield return new WaitForSeconds(5);
        ProjectilePool.Instance.LeaveProjectile(gameObject);
    }
}
