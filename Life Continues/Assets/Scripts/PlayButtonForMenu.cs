using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonForMenu : MonoBehaviour
{
     public GameObject fademenu;
 
   public void PlayFade()
   {
    fademenu.SetActive(true);
   }
   public void StartGame() 
   {
    SceneManager.LoadScene("cena1");
   }
}
