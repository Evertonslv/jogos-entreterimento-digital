using UnityEngine;
using UnityEngine.UI;

public class Propriedades : MonoBehaviour
{
    public static int QTDVIDAPADRAO = 8;
    public Text pontuacao;
    public GameObject vida1, vida2, vida3, vida4, vida5, vida6, vida7, vida8;

    public static bool ISLIMPANDO = false;
    // Indica para qual lado deve ir o objeto
    public static float VELOCIDADE_DENTES = 3f;
    public static float DESLOCAMENTO = 0.001f;
    public static int MOVIMENTO = 0;
    public static int PONTUACAO = 0;
    public static int QTDVIDA = QTDVIDAPADRAO;
    public static bool PAUSE = false;
    public static bool REINICIARJOGO = false;
    public static float LARGURABOTAO = 160;
    public static float ALTURABOTAO = 40;
    public static int LEVEL = 1;
    public static bool CRIARNOVOSOBJETOS = false;
    public static int QUANTIDADEOBJETOS = 0;

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

    public static void ReiniciarPropriedades()
    {
        CRIARNOVOSOBJETOS = false;
        QTDVIDA = QTDVIDAPADRAO;
        VELOCIDADE_DENTES = 3;
        QUANTIDADEOBJETOS = 0;
        ISLIMPANDO = false;
        DESLOCAMENTO = 0;
        PAUSE = false;
        MOVIMENTO = 0;
        PONTUACAO = 0;
        LEVEL = 1;
    }
}
