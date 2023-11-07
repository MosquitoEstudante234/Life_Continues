using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarInicial : MonoBehaviour
{
    public GameObject ActivatedObj, Collider, Player, Barcoco;
    


    private void OnTriggerStay2D(Collider2D collision)
    {
        ActivatedObj.SetActive(true);
        Collider.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ActivatedObj.SetActive(false);
        Player.transform.position = Barcoco.transform.position;
    }
}
