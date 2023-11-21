using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneFinal : MonoBehaviour
{
   public GameObject FadeBranco, Creditos;
 
    public void WhiteFade()
    {
      FadeBranco.SetActive(true);
    }

    public void Credits()
    {
        Creditos.SetActive(true);
    }
  
    public void MenuGame()
    {
      SceneManager.LoadScene("cena0");
    }
}
