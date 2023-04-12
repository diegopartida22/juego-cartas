using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Assertions;

public class CartaLoader : MonoBehaviour
{

    [SerializeField]
    private TMP_Text _nombre;

    [SerializeField]
    private TMP_Text _fuerza;

    [SerializeField]
    private SpriteRenderer _spriteRenderer;

    public void SetDatosCarta(CartaSO datosCarta)
    {
        Assert.IsNotNull(datosCarta, "Los datos de la carta no pueden ser nulos");
        _nombre.text = datosCarta.nombre;
        _fuerza.text = datosCarta.fuerza;
        _spriteRenderer.sprite = datosCarta.sprite;
    }
}
