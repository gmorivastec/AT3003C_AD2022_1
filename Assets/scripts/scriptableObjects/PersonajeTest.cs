using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeTest : MonoBehaviour
{

    [SerializeField]
    private Personaje _datosDePersonaje;

    // Start is called before the first frame update
    void Start()
    {
        print("hola soy el: " + _datosDePersonaje.tipoDePersonaje);
        print("mi fuerza es: " + _datosDePersonaje.fuerza);

        // RECOMENDACIÓN:
        // NO incluir prefab en scriptable object si no es indispensable
        // alternativas:
        // - parametrizar modelos
        // - parametrizar texturas
        // - parametrizar sonidos
        //
        Instantiate(
            _datosDePersonaje.modeloOriginal, 
            transform.position,
            _datosDePersonaje.modeloOriginal.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
