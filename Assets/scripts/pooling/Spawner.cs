using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject objetoASpawnear;
    
    [SerializeField]
    private string nombreDePool;
    
    [SerializeField]
    private float tiempoMaximoParaSpawn;

    private Pool pool;

    // Start is called before the first frame update
    void Start()
    {
        pool = PoolIndex.Instance.ObtenerPool(nombreDePool);
        
        if(pool == null)
            throw new System.Exception("POOL CON NOMBRE ESPECIFICADO NO EXISTE");

        StartCoroutine(Spawnear());
    }

    IEnumerator Spawnear() {

        while(true){

            yield return new WaitForSeconds(Random.Range(0, tiempoMaximoParaSpawn));
            pool.GetObject(transform.position);            
        }
    }
}
