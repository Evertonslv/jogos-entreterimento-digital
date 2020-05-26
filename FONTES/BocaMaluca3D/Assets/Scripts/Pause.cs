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
    public Button btnPause;
    public GUISkin personalizacaoButton;

    void Update() 
    {
        btnEsquerda.gameObject.SetActive(!Propriedades.PAUSE && Propriedades.QTDVIDA > 0);
        btnDireita.gameObject.SetActive(!Propriedades.PAUSE && Propriedades.QTDVIDA > 0);
        btnLimpar.gameObject.SetActive(!Propriedades.PAUSE && Propriedades.QTDVIDA > 0);
        btnPause.gameObject.SetActive(Propriedades.QTDVIDA > 0);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Propriedades.PAUSE = true;
    }

    void OnGUI()
    {   
        if(Propriedades.PAUSE)
        {      
            GUI.skin = personalizacaoButton;

            if (GUI.Button(new Rect(Screen.width/2-Propriedades.LARGURABOTAO/2 - 15, Screen.height/2 + Propriedades.ALTURABOTAO, Propriedades.LARGURABOTAO, Propriedades.ALTURABOTAO), "REINICIAR JOGO"))
            {
                ReiniciarJogo();
            }

            if (GUI.Button(new Rect(Screen.width/2-Propriedades.LARGURABOTAO/2 - 15, Screen.height/2 + Propriedades.ALTURABOTAO + 55, Propriedades.LARGURABOTAO, Propriedades.ALTURABOTAO), "CONTINUAR JOGO"))
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
