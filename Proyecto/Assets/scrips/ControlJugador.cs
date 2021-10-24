using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlJugador : MonoBehaviour
{
    public float rapidezDesplazamiento = 2f;
    public GameObject proyectil;
    public Camera camaraPrimeraPersona;
    public LayerMask piso;
    public float magnitudSalto;
    public ControlJuego controlJuego;
    public int vida = 1;
    private float cooldown;
    private bool pasotiempo= true;
    public Text textoCooldown;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pasotiempo = true;
        
        
    }


    void Update()
    {
        float movimientoAdelanteAtras = Input.GetAxis("Vertical") * rapidezDesplazamiento;
        float movimientoCostados = Input.GetAxis("Horizontal") * rapidezDesplazamiento;

        movimientoAdelanteAtras *= Time.deltaTime;
        movimientoCostados *= Time.deltaTime;

        transform.Translate(movimientoCostados, 0, movimientoAdelanteAtras);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetMouseButtonDown(0))
        {if (pasotiempo)
            {
                Ray ray = camaraPrimeraPersona.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

                GameObject pro;
                pro = Instantiate(proyectil, ray.origin, transform.rotation);

                Rigidbody rb = pro.GetComponent<Rigidbody>();
                rb.AddForce(camaraPrimeraPersona.transform.forward * 15, ForceMode.Impulse);

                Destroy(pro, 3);
                pasotiempo = false;
                cooldown = 2f;
            }
        }
        Cld();
        setearTextos();
     
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("aparicion"))
        {
            controlJuego.lvl2++;
        }
        if (other.gameObject.CompareTag("enemigo"))
        {
            vida = 0;
        }
        if (other.gameObject.CompareTag("fin"))
        {
            final();
        }
    }
    private void Cld()
    {
        if(!pasotiempo){
            
            cooldown -= Time.deltaTime;
            if (cooldown <= 0)
            { 
                pasotiempo = true;
                

            }
        }
    }
    private void setearTextos()
    {
        if (cooldown <= 0) textoCooldown.text = "Puedes disparar";
        else textoCooldown.text = "Proximo disparo en: " + cooldown.ToString("f0");

    }
    private void final()
    {
        SceneManager.LoadScene(1);    }
}
