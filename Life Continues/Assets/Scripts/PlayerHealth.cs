using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    int Health = 1;
    public GameObject DeathMenu, DeadPlayer;

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
            Mortis();
        }

        if (collision.gameObject.CompareTag("iceDMG") && iceResistance == false)
        {
            Debug.Log("damage");
            Health -= 1;
            Mortis();
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
            Mortis();
        }

        if (collision.gameObject.CompareTag("iceDMG") && iceResistance == false)
        {
            Debug.Log("damage");
            Health -= 1;
            Mortis();
        }
         if (collision.gameObject.CompareTag("acidDMG") && acidResistance == true)
        {
            Debug.Log("esta gamer?");
            Destroy(collision.gameObject);
            FindObjectOfType<AudioManager>().Play("Quebrar");
        }

        if (collision.gameObject.CompareTag("Voides"))
        {
            Debug.Log("damage");
            Health -= 1;
            Mortis();
        }

    }



    public void Mortis()
    {
        FindObjectOfType<AudioManager>().Play("Morte");
        DeadPlayer.SetActive(true);
        DeathMenu.SetActive(true);
        transform.position = FindObjectOfType<ItemScript>().RespawnPoint;
        FindObjectOfType<PlayerMoviment>().speed = 0f;
        FindObjectOfType<PlayerMoviment>().jumpingPower = 0f;
        //Time.timeScale = 0;
    }
}
