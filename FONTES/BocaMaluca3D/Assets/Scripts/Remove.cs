using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove : MonoBehaviour
{
    void Update()
    {
        if (this.transform.position.z < -296.9)
        {
           Propriedades.QTDVIDA -= 1;
           this.Destruir();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "escova")
        {
            Propriedades.PONTUACAO += 1;
            this.Destruir();
        }
    }

    void Destruir()
    {
        Destroy(this.gameObject);
    }
}
