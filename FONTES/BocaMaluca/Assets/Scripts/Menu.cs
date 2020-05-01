using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public Texture2D textureFundo;
    private float larguraBotao = 160;
    private float alturaBotao = 40;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0,0,Screen.width, Screen.height), textureFundo, ScaleMode.StretchToFill);

        if (GUI.Button(new Rect(Screen.width/2-larguraBotao/2, Screen.height/2 + alturaBotao - 30, larguraBotao, alturaBotao), "INICIAR JOGO"))
        {
            //SceneManager.LoadScene("fase", LoadSceneMode.Additive);
            Application.LoadLevel("fase");
        }
    }
}
