using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimentarMainCamera : MonoBehaviour
{
    public GUISkin personalizacaoButton;
    private bool iniciarJogo = false;
    private float timer = 0f;
    private Vector3 posicaoFinal = new Vector3(541f, 482.24f, -299.17f);
    private Quaternion rotacaoFinal = Quaternion.Euler(49.316f, 0f, 0f);

    void Update() 
    {
        if(iniciarJogo)
        {
            SetaValorPosicao();
            
            if(transform.rotation != rotacaoFinal)
            {
                SetaValorRotacao();
            }
            else
            {
                MudaCena();
            }
        }
    }

    void OnGUI()
    {
        if(!iniciarJogo) 
        {
            GUI.skin = personalizacaoButton;

            if (GUI.Button(new Rect(Screen.width/2-Propriedades.LARGURABOTAO/2 - 15, Screen.height/2 + Propriedades.ALTURABOTAO, Propriedades.LARGURABOTAO, Propriedades.ALTURABOTAO), "INICIAR JOGO"))
            {
                iniciarJogo = true;
            }
        }
    }

    void SetaValorPosicao() 
    {
        transform.position = Vector3.Slerp(transform.position, posicaoFinal, timer/50f);
        timer += Time.deltaTime;
    }

    void SetaValorRotacao()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, rotacaoFinal,  Time.deltaTime * 2.0f);
    }

    void MudaCena()
    {
        SceneManager.LoadScene("JogoPrincipal");
    }
}