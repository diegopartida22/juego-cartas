using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Movimiento : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5f;
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float velocidad = horizontal * _speed * Time.deltaTime;
        transform.Translate(velocidad, 0, 0);

        _animator.SetFloat("velocidad", velocidad);

        if (Input.GetButtonDown("Jump")){
            _animator.SetTrigger("hadouken");
        }

    }
    public void EjemploEventoAnimacion(){
        print("HADOUKEN");
    }
}


