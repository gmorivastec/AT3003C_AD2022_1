using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// los : significan herencia
// declaramos un subtipo de otro tipo
// en términos prácticos - fuente de donde vamos a utilizar
// recursos predefinidos (variables, métodos)

// scriptable objects
// definición de un tipo contenedor de datos
// sirve para tener a nivel asset un tipo de datos predefinido

// ejemplo:
// personaje estilo D&D

[CreateAssetMenu(menuName="ScriptableObjects/Personajes", fileName ="Personaje", order=1)]
public class Personaje : ScriptableObject
{

    public string tipoDePersonaje;
    public int fuerza;
    public int destreza;
    public int vitalidad;
    public int inteligencia;
    public int sabiduria;
    public int carisma;
    public GameObject modeloOriginal;
}
