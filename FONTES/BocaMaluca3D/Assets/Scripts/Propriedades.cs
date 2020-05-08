﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Propriedades : MonoBehaviour
{
    public Text pontuacao;
    public GameObject vida1, vida2, vida3, vida4, vida5, vida6, vida7, vida8;

    public static bool ISLIMPANDO = false;
    // Indica para qual lado deve ir o objeto
    public static int MOVIMENTO = 0;

    public static int PONTUACAO = 0;

    public static int QTDVIDA = 8;

    public static float VELOCIDADE_DENTES = 2;

    void Update()
    {
        pontuacao.text = PONTUACAO.ToString();

        vida1.SetActive(QTDVIDA > 0);
        vida2.SetActive(QTDVIDA > 1);
        vida3.SetActive(QTDVIDA > 2);
        vida4.SetActive(QTDVIDA > 3);
        vida5.SetActive(QTDVIDA > 4);
        vida6.SetActive(QTDVIDA > 5);
        vida7.SetActive(QTDVIDA > 6);
        vida8.SetActive(QTDVIDA > 7);
    }

}
