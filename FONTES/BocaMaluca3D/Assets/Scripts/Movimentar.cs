using UnityEngine;
using System.Collections;
using System;
using System.Net.Sockets;

public class Movimentar : MonoBehaviour
{
	private Material objMovimentar;
	private float deslocamento;
	public Boolean isMovimentaPorTransform = false;
	public Transform objMovimentar3D;

	void Start()
	{
		objMovimentar = GetComponent<Renderer>().material;
	}


	void Update()
	{
		if (isMovimentaPorTransform)
		{
			transform.Translate(0, (Propriedades.VELOCIDADE_DENTES) * 0.05f, 0);
		}
		else
		{
			deslocamento += 0.001f;
			objMovimentar.SetTextureOffset("_MainTex", new Vector2(0, deslocamento * Propriedades.VELOCIDADE_DENTES));
		}
	}
}