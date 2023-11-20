using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoxPorta : MonoBehaviour
{
    public GameObject BotaoTrigger, TutorialPortal;
 
   public void OnTriggerEnter2D(Collider2D col)
   { 
    if (col.CompareTag("ColliderPorta"))
    {
      BotaoTrigger.SetActive(true);
    }
        if (col.CompareTag("ColliderTutorial"))
        {
            TutorialPortal.SetActive(true);
        }
    }
   public void OnTriggerExit2D(Collider2D col)
   { 
    if (col.CompareTag("ColliderPorta"))
    {
      BotaoTrigger.SetActive(false);
    }
        if (col.CompareTag("ColliderTutorial"))
        {
            TutorialPortal.SetActive(false);
        }
    }
}
