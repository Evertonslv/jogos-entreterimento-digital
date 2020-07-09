using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MovimentaDireita : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Button btnDireita;

    private void Start()
    {
        btnDireita.gameObject.SetActive(false);
#if UNITY_ANDROID
        btnDireita.gameObject.SetActive(true);
#elif UNITY_IOS
        btnDireita.gameObject.SetActive(true);
#endif
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Propriedades.MOVIMENTO = -1;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Propriedades.MOVIMENTO = 0;
    }
}
