using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJuego : MonoBehaviour
{
    public GameObject jugador;
    public GameObject bot;
    public List<GameObject> listaEnemigos;
    float tiempoRestante;

    void Start()
    {
        ComenzarJuego();
    }

    void Update()
    {
        if (tiempoRestante == 0)
        {
            ComenzarJuego();
        }
    }

    void ComenzarJuego()
    {
        jugador.transform.position = new Vector3(0f, 0f, 0f);

        foreach (GameObject item in listaEnemigos)
            {
               Destroy(item);
            }
        listaEnemigos.Remove(bot);

        listaEnemigos.Add(Instantiate(bot, new Vector3(3, 0.5f, 4f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(-1, 0.5f, 4f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(3, 0.5f, 1f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(-1, 0.5f, 1f), Quaternion.identity));
        StartCoroutine(ComenzarCronometro(30));
     
    }

    public IEnumerator ComenzarCronometro(float valorCronometro = 30)
    {
        tiempoRestante = valorCronometro;
        while (tiempoRestante > 0)
        {
            Debug.Log("Restan " + tiempoRestante + " segundos.");
            yield return new WaitForSeconds(1.0f);
            tiempoRestante--;
        }
    }
}
