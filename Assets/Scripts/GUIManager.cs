using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    // RECOMENDACIÓN:
    // Con cualquier manager centralizado hacer singleton

    void Start()
    {
        // si necesitamos um objeto que permanezca entre escenas
        DontDestroyOnLoad(gameObject);
    }

    // Escuchar boton
    public void EscucharBoton()
    {
        print("Boton presionado");
        //SceneManager.LoadScene("ScriptableObject");
        SceneManager.LoadScene(2);

    }

    // Escuchar slider
    public void EscucharSlider(float valor)
    {
        print(string.Format("Slider: {0}", valor)); 

    }

    public void Salir()
    {   
        print("Salir");
        Application.Quit();
    }
}
