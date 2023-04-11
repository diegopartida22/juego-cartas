using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Carta", menuName = "ScriptableObjects/Carta", order = 1)]
public class CartaSO : ScriptableObject
{
    public string _nombre;
    public string _fuerza;
    public Sprite _sprite;

    public string nombre
    {
        get { return _nombre; }
    }

    public string fuerza
    {
        get { return _fuerza; }
    }

    public Sprite sprite
    {
        get { return _sprite; }
    }
}

