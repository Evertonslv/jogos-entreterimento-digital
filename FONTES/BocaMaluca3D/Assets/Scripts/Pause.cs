﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour, IPointerDownHandler
{
    public Button btnPause;
    private float larguraBotao = 160;
    private float alturaBotao = 40;

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