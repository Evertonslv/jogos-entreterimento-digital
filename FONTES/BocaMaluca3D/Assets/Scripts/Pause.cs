using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour, IPointerDownHandler
{
    public Button btnEsquerda;
    public Button btnDireita;
    public Button btnLimpar;
    private float larguraBotao = 160;
    private float alturaBotao = 40;

    void Update() 
    {
        btnEsquerda.gameObject.SetActive(!Propriedades.PAUSE);
        btnDireita.gameObject.SetActive(!Propriedades.PAUSE);
        btnLimpar.gameObject.SetActive(!Propriedades.PAUSE && Propriedades.QTDVIDA > 0);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Propriedades.PAUSE = true;
    }

    void OnGUI()
    {   
        if(Propriedades.PAUSE) 
        {       
            if (GUI.Button(new Rect(Screen.width/2-larguraBotao/2 - 15, Screen.height/2 + alturaBotao, larguraBotao, alturaBotao), "REINICIAR JOGO"))
            {
                ReiniciarJogo();
            }

            if (GUI.Button(new Rect(Screen.width/2-larguraBotao/2 - 15, Screen.height/2 + alturaBotao + 45, larguraBotao, alturaBotao), "CONTINUAR JOGO"))
            {
                Propriedades.PAUSE = false;
            }
        }
    }

    void ReiniciarJogo()
	{
 		Propriedades.ReiniciarPropriedades();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
    
}
