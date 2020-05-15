using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimentarMainCamera : MonoBehaviour
{
    private bool iniciarJogo = false;
    private float alturaBotao = 40;
    private float larguraBotao = 160;
    private float timer = 0f;
    private Vector3 posicaoFinal = new Vector3(541f, 482.24f, -299.17f);
    private Quaternion rotacaoFinal = Quaternion.Euler(49.316f, 0f, 0f);

    void Start() 
    {
        
    }

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
            if (GUI.Button(new Rect(Screen.width/2-larguraBotao/2 - 15, Screen.height/2 + alturaBotao, larguraBotao, alturaBotao), "INICIAR JOGO"))
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