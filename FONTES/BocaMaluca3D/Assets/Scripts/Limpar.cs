using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Limpar : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Button botaoLimpar;
    public AudioClip somLimpar;

    private void Start()
    {
        botaoLimpar.gameObject.SetActive(false);
#if UNITY_ANDROID
        botaoLimpar.gameObject.SetActive(true);
#elif UNITY_IOS
        botaoLimpar.gameObject.SetActive(true);
#endif
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Propriedades.ISLIMPANDO = true;
        GetComponent<AudioSource>().PlayOneShot(somLimpar, 0.5f);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Propriedades.ISLIMPANDO = false;
    }
}
