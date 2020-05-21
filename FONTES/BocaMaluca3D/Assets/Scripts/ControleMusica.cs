using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleMusica : MonoBehaviour
{
	private AudioSource audio;
    public AudioClip musicaDeFundo;
    public AudioClip somFimDeJogo;
    public AudioClip somLimpar;
    public AudioClip somNaoLimpou;
    public AudioClip somLimpou;

    void Start()
    {
        audio = new AudioSource();
        audio.clip = musicaDeFundo;
        audio.loop = true;
        audio.playOnAwake = true;
    }

    void Update()
    {
        if(Propriedades.QTDVIDA == 0)
        {
            audio.PlayOneShot(somFimDeJogo, 1.0f);
        }        
    }

}
