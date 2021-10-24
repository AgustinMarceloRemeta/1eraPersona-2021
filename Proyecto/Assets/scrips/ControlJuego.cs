using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlJuego : MonoBehaviour
{
    public GameObject jugador;
    public GameObject bot;
    public List<GameObject> listaEnemigos;
    float tiempoRestante;
    public int lvl2= 0;
   public ControlJugador controlJugador;
    public Text TextoTiempo;
    public Text killsText;
    public int kills= 0;

    void Start()
    {
        ComenzarJuego();

        StartCoroutine(ComenzarCronometro(180));
    }

    void Update()
    {
        parte2();
        if (tiempoRestante == 0|| controlJugador.vida == 0)
        {
           
            ComenzarJuego();
            lvl2 = 0;
            controlJugador.vida = 1;
           

        }
        TextoTiempo.text = "Tiempo restante: " + tiempoRestante;
        killsText.text = "kills: " + kills;
    }

    void ComenzarJuego()
    {
        
        jugador.transform.position = new Vector3(0f, 1f, 15f);

        foreach (GameObject item in listaEnemigos)
            {
               Destroy(item);
            }
        listaEnemigos.Remove(bot);

             
        listaEnemigos.Add(Instantiate(bot, new Vector3(3, -1f, 22f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(-1, -1f, 22f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(1, -1f, 24f), Quaternion.identity));

        listaEnemigos.Add(Instantiate(bot, new Vector3(3, -1f, 30f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(-1, -1f, 30f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(1, -1f, 32f), Quaternion.identity));

        listaEnemigos.Add(Instantiate(bot, new Vector3(3, -1f, 38f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(-1, -1f, 38f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(1, -1f, 40f), Quaternion.identity));

        listaEnemigos.Add(Instantiate(bot, new Vector3(3, -1f, 46f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(-1, -1f, 46f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(1, -1f, 48f), Quaternion.identity));

        listaEnemigos.Add(Instantiate(bot, new Vector3(3, -1f, 54f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(-1, -1f, 54f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(1, -1f, 56f), Quaternion.identity));

        listaEnemigos.Add(Instantiate(bot, new Vector3(3, -1f, 62f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(-1, -1f, 62f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(1, -1f, 64f), Quaternion.identity));

        listaEnemigos.Add(Instantiate(bot, new Vector3(3, -1f, 70f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(-1, -1f, 70f), Quaternion.identity));
        listaEnemigos.Add(Instantiate(bot, new Vector3(1, -1f, 72f), Quaternion.identity));

        
     
    }

    public IEnumerator ComenzarCronometro(float valorCronometro = 1000)
    {
        tiempoRestante = valorCronometro;
        while (tiempoRestante > 0)
        {
            yield return new WaitForSeconds(1.0f);
            tiempoRestante--;
        }
    }
    void parte2()
    {
        if (lvl2== 1)
        {
            listaEnemigos.Add(Instantiate(bot, new Vector3(9, -1f, 22f), Quaternion.identity));
            listaEnemigos.Add(Instantiate(bot, new Vector3(14, -1f, 22f), Quaternion.identity));
            listaEnemigos.Add(Instantiate(bot, new Vector3(11, -1f, 24f), Quaternion.identity));

            listaEnemigos.Add(Instantiate(bot, new Vector3(9, -1f, 30f), Quaternion.identity));
            listaEnemigos.Add(Instantiate(bot, new Vector3(14, -1f, 30f), Quaternion.identity));
            listaEnemigos.Add(Instantiate(bot, new Vector3(11, -1f, 32f), Quaternion.identity));

            listaEnemigos.Add(Instantiate(bot, new Vector3(9, -1f, 38f), Quaternion.identity));
            listaEnemigos.Add(Instantiate(bot, new Vector3(14, -1f, 38f), Quaternion.identity));
            listaEnemigos.Add(Instantiate(bot, new Vector3(11, -1f, 40f), Quaternion.identity));

            listaEnemigos.Add(Instantiate(bot, new Vector3(9, -1f, 46f), Quaternion.identity));
            listaEnemigos.Add(Instantiate(bot, new Vector3(14, -1f, 46f), Quaternion.identity));
            listaEnemigos.Add(Instantiate(bot, new Vector3(11, -1f, 48f), Quaternion.identity));

            listaEnemigos.Add(Instantiate(bot, new Vector3(9, -1f, 54f), Quaternion.identity));
            listaEnemigos.Add(Instantiate(bot, new Vector3(14, -1f, 54f), Quaternion.identity));
            lvl2++;
        }
    }
}
