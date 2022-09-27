using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI texto;

    public static UIManager Instance {
        get;
        private set;
    }

    // Start is called before the first frame update
    void Start()
    {
        if(Instance != null)
            Destroy(gameObject);

        Instance = this;

        texto.text = "EL PUNTAJE";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
