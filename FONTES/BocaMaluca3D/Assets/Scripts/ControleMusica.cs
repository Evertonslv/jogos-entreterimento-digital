using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleMusica : MonoBehaviour
{
	public AudioSource audioPrincipal;
    public AudioSource efeito;
    public AudioClip somFimDeJogo;
    public AudioClip somLimpar;
    public AudioClip somNaoLimpou;
    public AudioClip somLimpou;
    private int pontuacao;
    private int qtdVida = Propriedades.QTDVIDAPADRAO;
    
    void Update()
    {        
        SomGameOver();
        SomLimpar();
        SomLimpou();
        SomNaoLimpou();
    }

    void SomGameOver() 
    {
        if(Propriedades.QTDVIDA == 0 && audioPrincipal.isPlaying)
        {
            Propriedades.ISLIMPANDO = false;
            efeito.PlayOneShot(somFimDeJogo);
            audioPrincipal.Stop();
        }
        else if(Propriedades.QTDVIDA > 0 && !audioPrincipal.isPlaying && !Propriedades.PAUSE)
        {
            audioPrincipal.Play();
        }
        else if(Propriedades.PAUSE && audioPrincipal.isPlaying) 
        {
            audioPrincipal.Stop();
        }
    }

    void SomLimpar() 
    {
        if(Propriedades.ISLIMPANDO)
        {
            if(!efeito.isPlaying)
            {
                efeito.PlayOneShot(somLimpar);
            }
        }
    }

    void SomLimpou() 
    {
        if(pontuacao != Propriedades.PONTUACAO && Propriedades.PONTUACAO > 0)
        {
            efeito.PlayOneShot(somLimpou);
        }
        
        pontuacao = Propriedades.PONTUACAO;
    }

    void SomNaoLimpou()
    {
        if(qtdVida != Propriedades.QTDVIDA && Propriedades.QTDVIDA < Propriedades.QTDVIDAPADRAO)
        {
            efeito.PlayOneShot(somNaoLimpou, 2F);
        }
        
        qtdVida = Propriedades.QTDVIDA;
    }
}
