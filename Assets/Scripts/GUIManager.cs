using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    [SerializeField]
    private CartaSO[] _cartas;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        _cartas = Resources.LoadAll<CartaSO>("ScriptableObjects");
    }

    public void EscucharBoton()
    {
        print("Boton presionado");

        List<CartaSO> cartasAleatorias = new List<CartaSO>();
        while (cartasAleatorias.Count < 5)
        {
            CartaSO carta = _cartas[Random.Range(0, _cartas.Length)];
            if (!cartasAleatorias.Contains(carta))
            {
                cartasAleatorias.Add(carta);
            }
        }

        CartaLoader[] loaders = FindObjectsOfType<CartaLoader>();
        for (int i = 0; i < loaders.Length; i++)
        {
            loaders[i].SetDatosCarta(cartasAleatorias[i]);
        }
    }

    public void Salir()
    {   
        print("Salir");
        Application.Quit();
    }
}
