using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Assertions;

public class CartaLoader : MonoBehaviour
{

    [SerializeField]
    private CartaSO _datos;

    [SerializeField]
    private TMP_Text _nombre;

    [SerializeField]
    private TMP_Text _fuerza;

    [SerializeField]
    private SpriteRenderer _spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        Assert.IsNotNull(_datos, "Los datos de la carta no pueden ser nulos");
        _nombre.text = _datos.nombre;
        _fuerza.text = _datos.fuerza;
        _spriteRenderer.sprite = _datos.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
