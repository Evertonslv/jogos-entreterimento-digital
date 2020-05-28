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
            SetaValorRotacao();
            SetaValorPosicao();

            timer += Time.deltaTime;
            
            if(transform.position == posicaoFinal && transform.rotation == rotacaoFinal)
            {
                MudaCena();
            }
        }
    }

    void SetaValorPosicao() 
    {
        transform.position = Vector3.Slerp(transform.position, posicaoFinal, timer/20f);
    }

    void SetaValorRotacao()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, rotacaoFinal,  timer/20f);
    }

    void MudaCena()
    {
        SceneManager.LoadScene("JogoPrincipal");
    }
    
    void OnGUI()
    {
        if(!iniciarJogo)
        {
            GUI.skin = personalizacaoButton;

            if (GUI.Button(new Rect(Screen.width/2-Propriedades.LARGURABOTAO/2 + 18, Screen.height/2 + Propriedades.ALTURABOTAO + 80, Propriedades.LARGURABOTAO, Propriedades.ALTURABOTAO), "INICIAR JOGO"))
            {
                iniciarJogo = true;
            }
        }
    }
}