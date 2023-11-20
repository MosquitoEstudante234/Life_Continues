using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoxPorta : MonoBehaviour
{
    public GameObject BotaoTrigger, TutorialPortal, TriggerFinal;
 
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
        if (col.CompareTag("ColliderFinal"))
        {
            TriggerFinal.SetActive(true);
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
        if (col.CompareTag("ColliderFinal"))
        {
            TriggerFinal.SetActive(false);
        }
    }
}
