using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimentarMainCamera : MonoBehaviour
{
    private bool iniciarJogo = false;
    private float alturaBotao = 40;
    private float larguraBotao = 160;
    private float velocidadeMovimento = 0.02f;
    private float velocidadeMovimentoRotation = 0.00001f;
    private Vector3 positionFinal = new Vector3(541.3f, 482.24f, -299.17f);
    private Quaternion rotationFinal = Quaternion.Euler(49.3f, 0f, 0f);

    void Start() 
    {
        
    }

    void Update() 
    {
        if(iniciarJogo)
        {
            if(transform.rotation != rotationFinal)
            {
                setValueRotation();
            }
        }
    }

    void OnGUI()
    {
        if(!iniciarJogo) 
        {
            if (GUI.Button(new Rect(Screen.width/2-larguraBotao/2 - 15, Screen.height/2 + alturaBotao, larguraBotao, alturaBotao), "INICIAR JOGO"))
            {
                iniciarJogo = true;
            }
        }
    }

    void setValuePosition() {
        float positionX = transform.position.x;
        float positionY = transform.position.y;
        float positionZ = transform.position.z;

        if(positionX < 541.3f)
        {
            positionX += positionX * velocidadeMovimento * Time.deltaTime;
        }
        else
        {
            positionX = 541.3f;
        }

        if(positionY > 482.24f)
        {
            positionY -= positionY * velocidadeMovimento * Time.deltaTime;
        }
        else
        {
            positionY = 482.24f;
        }

        if(positionZ > -299.17f)
        {
            positionZ += positionZ * velocidadeMovimento * Time.deltaTime;
        }
        else
        {
            positionZ = -299.17f;
        }

        transform.position = new Vector3(positionX, positionY, positionZ);
    }

    void setValueRotation()
    {
        float rotationX = transform.rotation.x;
        float rotationY = transform.rotation.y;
        float rotationZ = transform.rotation.z;

        Debug.Log("x" + rotationX);
        Debug.Log("y" + rotationY);
        Debug.Log("z" + rotationZ);

        if(rotationX > 49.316f)
        {
            rotationX -= rotationX * velocidadeMovimentoRotation * Time.deltaTime;
        }
        else
        {
            rotationX = 49.316f;
        }

        if(rotationY > 0f)
        {
            rotationY -= rotationY * velocidadeMovimentoRotation * Time.deltaTime;
        }
        else
        {
            rotationY = 0f;
        }

        if(rotationZ > 0f)
        {
            rotationZ -= rotationZ * velocidadeMovimentoRotation * Time.deltaTime;
        }
        else
        {
            rotationZ = 0f;
        }

        Debug.Log("x" + rotationX);
        Debug.Log("y" + rotationY);
        Debug.Log("z" + rotationZ);

        transform.rotation = Quaternion.Euler(rotationX, rotationY, rotationZ);
    }
}