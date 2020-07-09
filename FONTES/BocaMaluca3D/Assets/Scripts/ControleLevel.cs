using UnityEngine;
using UnityEngine.UI;

public class ControleLevel : MonoBehaviour
{
    private static float TIMEREMAININGDEFAULT = 3;
    private float timeRemaining = TIMEREMAININGDEFAULT;
    public Text txtLevel;

    void Update()
    {
        if (!Propriedades.CRIARNOVOSOBJETOS && Propriedades.QUANTIDADEOBJETOS == 0 && Propriedades.QTDVIDA > 0)
        {
            txtLevel.text = "Level " + Propriedades.LEVEL;
            txtLevel.gameObject.SetActive(true);
                        
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                if(Propriedades.LEVEL > 1)
                {
                    Propriedades.VELOCIDADE_DENTES += 0.7f;
                }

                Propriedades.LEVEL++;
                Propriedades.CRIARNOVOSOBJETOS = true;
                txtLevel.gameObject.SetActive(false);
                timeRemaining = TIMEREMAININGDEFAULT;
            }
        }
    }


}
