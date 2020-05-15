using System.Collections;
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
        if(!Propriedades.PAUSE && Propriedades.QTDVIDA > 0)
        {
            CriaObjeto();
        }       
    }

    void CriaObjeto()
    {
        segundos += Time.deltaTime % 60;

        if (ultimoTempoCriado == 0 || (segundos - ultimoTempoCriado) > (1.5-(Propriedades.VELOCIDADE_DENTES*0.08)))
        {
            int posicao = Random.Range(1, 5);
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
                case 4:
                    objPos = posicao4;
                    break;
                case 5:
                    objPos = posicao5;
                    break;
            }

            spawnee.transform.localScale = objPos.localScale;
            spawnee.transform.rotation = objPos.rotation;

            Instantiate(spawnee, objPos.position, objPos.rotation);
            ultimoTempoCriado = segundos;
        }
    }
}
