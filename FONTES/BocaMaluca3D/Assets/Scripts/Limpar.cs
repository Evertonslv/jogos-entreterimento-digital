using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Limpar : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Button botaoLimpar;
    
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
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Propriedades.ISLIMPANDO = false;
    }
}
