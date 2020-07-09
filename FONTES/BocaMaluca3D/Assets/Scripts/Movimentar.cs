using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Movimentar : MonoBehaviour
{
	private bool gameOver = false;
	private Material objMovimentar;	
	public Text txtFimDeJogo;
	public Text txtRecorde;
	public Text descricaoPlacaRecorde;
	public Transform objMovimentar3D;
	public Boolean isMovimentaPorTransform = false;
	public GUISkin personalizacaoButton;
	private int pontuacaoAtual = Propriedades.PONTUACAO;

	void Start()
	{
		objMovimentar = GetComponent<Renderer>().material;
		
		if(txtFimDeJogo != null)
		{
			txtFimDeJogo.gameObject.SetActive(false);
		}

		if (txtRecorde != null)
		{
			txtRecorde.gameObject.SetActive(false);
		}

		if(descricaoPlacaRecorde != null)
		{
			descricaoPlacaRecorde.text = descricaoPlacaRecorde.text + PlayerPrefs.GetInt("recorde");
		}
	}

	void Update()
	{
		if(!gameOver)
		{
			if(Propriedades.QTDVIDA == 0)
			{
				if (!objMovimentar3D)
				{
					gameOver = true;

					if (Propriedades.PONTUACAO > PlayerPrefs.GetInt("recorde"))
					{
						PlayerPrefs.SetInt("recorde", Propriedades.PONTUACAO);
					
						txtRecorde.text = txtRecorde.text + Propriedades.PONTUACAO;
						txtRecorde.gameObject.SetActive(true);
					}
					else
					{
						txtFimDeJogo.gameObject.SetActive(true);
					}
				}
			}
			else if(!Propriedades.PAUSE)
			{
				MovimentaDentes();
			}
		}
	}

	void MovimentaDentes() 
	{
		if (isMovimentaPorTransform)
		{
			transform.Translate(0, (Propriedades.VELOCIDADE_DENTES * 0.05f), 0);
		}
		else
		{
			Propriedades.DESLOCAMENTO += 0.001f;
			objMovimentar.SetTextureOffset("_MainTex", new Vector2(0, Propriedades.DESLOCAMENTO * Propriedades.VELOCIDADE_DENTES));
		}
	}

	void MovimentaSujeiras()
	{
		transform.Translate(0, (Propriedades.VELOCIDADE_DENTES * 0.05f), 0);
	}

	void OnGUI()
    {   
        if(gameOver) 
        {
			GUI.skin = personalizacaoButton;
			
            if (GUI.Button(new Rect(Screen.width/2-Propriedades.LARGURABOTAO/2, Screen.height/2 + Propriedades.ALTURABOTAO, Propriedades.LARGURABOTAO, Propriedades.ALTURABOTAO), "REINICIAR JOGO"))
            {
               ReiniciarJogo();
            }
        }
    }

	void ReiniciarJogo()
	{
 		Propriedades.ReiniciarPropriedades();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}