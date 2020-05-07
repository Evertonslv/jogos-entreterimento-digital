using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PersonagemControle : MonoBehaviour
{
    // Contem a referencia do objeto da escova
    public Transform escova;
    private Collider colisao;

    // Indicacao da direcao
    private bool isEsquerda = true;
    private double anguloMaximo = 0.08347217;
    private float velocidadeLimpa = 00001;
    private float velocidadeMovimenta = 0.050f;

    void Start()
    {
        colisao = escova.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
            
        float valorY = escova.rotation.y, valorX = escova.rotation.x, valorZ = escova.rotation.z;
        //Input.GetMouseButtonDown(0)
        //Input.GetMouseButtonUp(0)

#if !UNITY_ANDROID || !UNITY_IOS
        Propriedades.ISLIMPANDO = Input.GetKey(KeyCode.Space);
#endif
        if (Propriedades.ISLIMPANDO)
        {

            if (isEsquerda)
            {
                if (-anguloMaximo >= valorY)
                {
                    isEsquerda = false;
                }
                else
                {
                    valorY += velocidadeLimpa;
                }
            }
            else
            {
                if (anguloMaximo <= valorY)
                {
                    isEsquerda = true;
                }
                else
                {
                    valorY -= velocidadeLimpa;
                }
            }

            escova.RotateAround(escova.position, Vector3.back, valorY);
        }
        else
        {
            isEsquerda = true;
            escova.RotateAround(escova.position, Vector3.back, 0);
        }

        if (Propriedades.MOVIMENTO == 1 || Input.GetKey(KeyCode.LeftArrow))
        {
            if(escova.position.x > 537.0508)
                escova.position = new Vector3(escova.position.x - velocidadeMovimenta, escova.position.y, escova.position.z);
        }else if (Propriedades.MOVIMENTO == -1 || Input.GetKey(KeyCode.RightArrow))
        {
            if(escova.position.x < 544.399)
            escova.position = new Vector3(escova.position.x + velocidadeMovimenta, escova.position.y, escova.position.z);
        }

        colisao.enabled = Propriedades.ISLIMPANDO;

        Debug.Log(Propriedades.QTDVIDA);
        Debug.Log(Propriedades.PONTUACAO);
    }
}
