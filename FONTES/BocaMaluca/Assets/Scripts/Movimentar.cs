using UnityEngine;
using System.Collections;

public class Movimentar : MonoBehaviour
{
	private Material objMovimentar;
	public Animator animator;
	public SpriteRenderer spriteRenderer;
	public float velocidade;
	private float deslocamento;
	private float contagem = 5f;

	void Start()
	{
		objMovimentar = GetComponent<Renderer>().material;
		animator.speed = 0.1f;
	}

	void Update()
	{
		if(contagem > 0) {
			contagem -= Time.deltaTime;
		} else {
			spriteRenderer.enabled = false;
			deslocamento += 0.001f;
			objMovimentar.SetTextureOffset("_MainTex", new Vector2(0, deslocamento * velocidade));
		}
	}

	void OnGUI() {

	}
}