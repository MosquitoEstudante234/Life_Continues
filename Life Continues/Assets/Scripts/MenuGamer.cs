using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGamer : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("cena1");
    }
    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Saindo...");
    }

}