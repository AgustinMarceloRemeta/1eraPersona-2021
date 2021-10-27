using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBot : MonoBehaviour
{
    private int hp;
    private GameObject jugador;
    public float rapidez;
    private ControlJuego controlJuego;


    void Start()
    {
        hp = 100;
        jugador = GameObject.Find("Jugador");
        controlJuego = FindObjectOfType<ControlJuego>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(jugador.transform);
        transform.Translate(rapidez * Vector3.forward * Time.deltaTime);
        

    }
    public void recibirDa�o()
    {
        hp = hp - 100;

        if (hp <= 0)
        {
            this.desaparecer();
            controlJuego.kills++;
        }
    }

    private void desaparecer()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bala"))
        {
            recibirDa�o();
        }
    }
}


