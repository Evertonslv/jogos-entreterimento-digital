using UnityEngine;
using System.Collections;

public class Movimentar : MonoBehaviour
{
	private Material objMovimentar;
	public float velocidade;
	private float deslocamento;
	
	void Start()
	{
		objMovimentar = GetComponent<Renderer>().material;
	}

	void Update()
	{
		deslocamento += 0.001f;
		objMovimentar.SetTextureOffset("_MainTex", new Vector2(0, deslocamento * velocidade));
	}
}