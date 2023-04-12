using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GUIManager : MonoBehaviour
{
    [SerializeField]
    private CartaSO[] _cartas;

    [SerializeField]
    private TMP_Text _textoPokemonesDisponibles;

        [SerializeField]
    private TMP_Text _textoPokemonesDisponibles2;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        _cartas = Resources.LoadAll<CartaSO>("ScriptableObjects");
        ActualizarTextoPokemonesDisponibles();
    }

    public void EscucharBoton()
    {
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

    public void VerPokemonesDisponibles(){
        ActualizarTextoPokemonesDisponibles();
    }

    private void ActualizarTextoPokemonesDisponibles(){
        string nombresPokemones = "";
        for (int i = 0; i < 5; i++){
            nombresPokemones += _cartas[i].nombre + "\n";
        }
        _textoPokemonesDisponibles.text = nombresPokemones;

        string nombresPokemones2 = "";
        for (int i = 5; i < 10; i++){
            nombresPokemones2 += _cartas[i].nombre + "\n";
        }
        _textoPokemonesDisponibles2.text = nombresPokemones2;
    }

    public void Salir()
    {   
        print("Salir");
        Application.Quit();
    }
}
