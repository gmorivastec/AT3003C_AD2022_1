using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{

    public static State Instance {
        get;
        private set;
    }

    public int Score {
        get;
        private set;
    }

    // Start is called before the first frame update
    void Start()
    {
        if(Instance == null)
            Destroy(gameObject);
        
        Instance = this;

        Score = 0;
    }

    public void UpdateScore(int points) {
        Score += points;
    }
}