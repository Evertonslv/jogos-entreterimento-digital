using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MovimentaEsquerda : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Button btnEsquerda;

    private void Start()
    {
        btnEsquerda.gameObject.SetActive(false);
#if UNITY_ANDROID
        btnEsquerda.gameObject.SetActive(true);
#elif UNITY_IOS
        btnEsquerda.gameObject.SetActive(true);
#endif
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Propriedades.MOVIMENTO = 1;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Propriedades.MOVIMENTO = 0;
    }
}
