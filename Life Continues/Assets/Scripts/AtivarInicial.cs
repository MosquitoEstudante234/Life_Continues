using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarInicial : MonoBehaviour
{
    public GameObject ActivatedObj, Collider, Player, Barcoco, Fade, Moldura;
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D col)
    {
       if (Player.CompareTag("Barcoco"))
        {
            Fade.SetActive(false);
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        ActivatedObj.SetActive(true);
        Collider.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ActivatedObj.SetActive(false);
        Player.transform.position = Barcoco.transform.position;
        animator.SetBool("IsOpen", false);
        Fade.SetActive(true);
        Moldura.SetActive(true);
    }
}
