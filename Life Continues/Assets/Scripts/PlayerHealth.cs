using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    int Health = 1;
    [SerializeField] public static bool fireResistance = false;
    [SerializeField] public static bool iceResistance = false;
    [SerializeField] public static bool acidResistance = false;

    private void Start()
    {
        Health = 1;
     fireResistance = false;
     iceResistance = false;
     acidResistance = false;

}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("fireFruit"))
        {
            fireResistance = true;
            iceResistance = false;
            acidResistance = false;
        }


        if (collision.gameObject.CompareTag("iceFruit"))
        {
            fireResistance = false;
            iceResistance = true;
            acidResistance = false;
        }
         if (collision.gameObject.CompareTag("acidFruit"))
        {
            fireResistance = false;
            iceResistance = false;
            acidResistance = true;
        }
        if (collision.gameObject.CompareTag("StatusRemover"))
        {
            fireResistance = false;
            iceResistance = false;
            acidResistance = false;
        }



        //caso de errado deleta até as chaves da função.



        if (collision.gameObject.CompareTag("FireDMG") && fireResistance == false)
        {
            Debug.Log("damage");
            Health -= 1;
            FindObjectOfType<AudioManager>().Play("Morte");
        }

        if (collision.gameObject.CompareTag("iceDMG") && iceResistance == false)
        {
            Debug.Log("damage");
            Health -= 1;
            FindObjectOfType<AudioManager>().Play("Morte");
        }
        if (collision.gameObject.CompareTag("acidDMG") && acidResistance == true)
        {
            Debug.Log("esta gamer?");
            Destroy(collision.gameObject);
            FindObjectOfType<AudioManager>().Play("Quebrar");
        }
    }
    //essa em ciminha





    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("FireDMG") && fireResistance == false)
        {
            Debug.Log("damage");
            Health -= 1;
            FindObjectOfType<AudioManager>().Play("Morte");
        }

        if (collision.gameObject.CompareTag("iceDMG") && iceResistance == false)
        {
            Debug.Log("damage");
            Health -= 1;
            FindObjectOfType<AudioManager>().Play("Morte");
        }
         if (collision.gameObject.CompareTag("acidDMG") && acidResistance == true)
        {
            Debug.Log("esta gamer?");
            Destroy(collision.gameObject);
            FindObjectOfType<AudioManager>().Play("Quebrar");
        }
    }
}
