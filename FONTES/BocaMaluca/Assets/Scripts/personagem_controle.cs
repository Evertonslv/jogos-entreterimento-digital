using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

public class personagem_controle : MonoBehaviour
{
    public const string ARRASTAR_TAG = "UIArrastar";

    //Controla as variaveis do animator
    private Animator animator;

    private Transform personagem;

    void Start()
    {
        animator = GetComponent<Animator>();
        personagem = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("limpando", true);
        }

        if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("limpando", false);
        }
    }
}
