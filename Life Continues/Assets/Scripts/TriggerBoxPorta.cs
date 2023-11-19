using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoxPorta : MonoBehaviour
{
    public GameObject BotaoTrigger;
 
   public void OnTriggerEnter2D(Collider2D col)
   { 
    if (col.CompareTag("ColliderPorta"))
    {
      BotaoTrigger.SetActive(true);
    }
   }
   public void OnTriggerExit2D(Collider2D col)
   { 
    if (col.CompareTag("ColliderPorta"))
    {
      BotaoTrigger.SetActive(false);
    }
   }
}
