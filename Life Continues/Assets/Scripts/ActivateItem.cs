using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateItem : MonoBehaviour
{
    public GameObject ActivatedObj;

    private void OnTriggerStay2D(Collider2D collision)
    {
        ActivatedObj.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ActivatedObj.SetActive(false);
    }
}
