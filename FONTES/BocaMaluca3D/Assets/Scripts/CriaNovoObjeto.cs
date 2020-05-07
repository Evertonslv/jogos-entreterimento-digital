﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriaNovoObjeto : MonoBehaviour
{
    public Transform posicao1;
    public Transform posicao2;
    public Transform posicao3;
    public Transform posicao4;
    public Transform posicao5;
    public GameObject spawnee;
    private float ultimoTempoCriado = 0;
    private float segundos = 0;

    void Update()
    {
       segundos += Time.deltaTime % 60;

        if (ultimoTempoCriado == 0 || (segundos - ultimoTempoCriado) > 3.0)
        {
            int posicao = Random.Range(1, 3);
            Transform objPos = null;

            switch (posicao)
            {
                case 1:
                    objPos = posicao1;
                    break;

                case 2:
                    objPos = posicao2;
                    break;

                case 3:
                    objPos = posicao3;
                    break;
            }

            spawnee.transform.localScale = objPos.localScale;
            spawnee.transform.rotation = objPos.rotation;

            Instantiate(spawnee, objPos.position, objPos.rotation);
            ultimoTempoCriado = segundos;
           }    
       }
}