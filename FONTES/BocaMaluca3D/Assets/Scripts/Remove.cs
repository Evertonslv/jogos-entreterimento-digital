using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove : MonoBehaviour
{
    public AudioClip somNaoLimpou;
    public AudioClip somLimpou;
    
    void Update()
    {
        if (this.transform.position.z < -296.9)
        {
            GetComponent<AudioSource>().PlayOneShot(somNaoLimpou);
            Propriedades.QTDVIDA -= 1;
            this.Destruir();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "escova")
        {
            GetComponent<AudioSource>().PlayOneShot(somLimpou);
            Propriedades.PONTUACAO += 1;

            if (Propriedades.PONTUACAO > 0 && Propriedades.PONTUACAO % 3 == 0)
            {
                Propriedades.VELOCIDADE_DENTES += Time.deltaTime * 0.2f;
            }

            this.Destruir();
        }
    }

    void Destruir()
    {
        Destroy(this.gameObject);
    }
}
