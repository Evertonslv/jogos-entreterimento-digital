using UnityEngine;
public class Remove : MonoBehaviour
{
    private static int controlePontuacao = 20;

    void Update()
    {        
        if (PodeDestruir())
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

            Debug.Log(controlePontuacao);

            if ((Propriedades.PONTUACAO % controlePontuacao) == 0)
            {
                controlePontuacao += (20 + (Propriedades.LEVEL * 3));
                Propriedades.CRIARNOVOSOBJETOS = false;
            }

            this.Destruir();
        }
    }

    bool PodeDestruir()
    {
        return this.transform.position.z < -296.9 ||
            (this.transform.position.x < 538.42 && this.transform.position.y > 473.20) ||
            (this.transform.position.x < 540.02 && this.transform.position.y > 473.70);
    }

    void Destruir()
    {
        Propriedades.QUANTIDADEOBJETOS--;
        Destroy(this.gameObject);
    }
}
