using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolIndex : MonoBehaviour
{

    // vamos a hacer un index con las pools que haya
    // para ello necesitamos una estructura
    private Dictionary<string, Pool> poolsDict;
    public string[] llaves;
    public Pool[] pools;

    // lo queremos singleton
    public static PoolIndex Instance {
        get;
        private set;
    }

    // Start is called before the first frame update
    void Awake()
    {
        if(Instance != null){
            Destroy(gameObject);
        }

        // acuérdense de inicializar objetos para que no nos de un null reference
        poolsDict = new Dictionary<string, Pool>();

        for(int i = 0; i < llaves.Length; i++){

            poolsDict.Add(llaves[i], pools[i]);
        }

        Instance = this;
    }

    public Pool ObtenerPool(string nombreDePool){
        
        if(!poolsDict.ContainsKey(nombreDePool))
            return null;

        return poolsDict[nombreDePool];
    }
}
