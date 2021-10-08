using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBot : MonoBehaviour
{
    private int hp;

    void Start()
    {
        hp = 100;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void recibirDaño()
    {
        hp = hp - 25;

        if (hp <= 0)
        {
            this.desaparecer();
        }
    }

    private void desaparecer()
    {
        Destroy(gameObject);
    }

}
