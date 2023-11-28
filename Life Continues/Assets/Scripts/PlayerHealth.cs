using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    int Health = 1;
    public GameObject DeathMenu, IceBerry, FireBerry, AcidBerry;
    public Animator animator;
    int normalLayer = 0; // Assumindo que a camada normal é 0
    int fireLayer = 1;   // Assumindo que a camada de fogo é 1
    int acidLayer = 2;   // Assumindo que a camada de ácido é 2
    int iceLayer = 3;

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
            FireBerry.SetActive(true);
            IceBerry.SetActive(false);
            AcidBerry.SetActive(false);

            animator.SetLayerWeight(iceLayer, 0f);
            animator.SetLayerWeight(fireLayer, 1f);
            animator.SetLayerWeight(acidLayer, 0f);
        }


        if (collision.gameObject.CompareTag("iceFruit"))
        {
            fireResistance = false;
            iceResistance = true;
            acidResistance = false;
            FireBerry.SetActive(false);
            IceBerry.SetActive(true);
            AcidBerry.SetActive(false);
            
            animator.SetLayerWeight(iceLayer, 1f);
            animator.SetLayerWeight(fireLayer, 0f);
            animator.SetLayerWeight(acidLayer, 0f);
        }
         if (collision.gameObject.CompareTag("acidFruit"))
        {
            fireResistance = false;
            iceResistance = false;
            acidResistance = true;
            FireBerry.SetActive(false);
            IceBerry.SetActive(false);
            AcidBerry.SetActive(true);

            animator.SetLayerWeight(normalLayer, 0f);
            animator.SetLayerWeight(iceLayer, 0f);
            animator.SetLayerWeight(fireLayer, 0f);
            animator.SetLayerWeight(acidLayer, 1f);
        }
        if (collision.gameObject.CompareTag("StatusRemover"))
        {
            fireResistance = false;
            iceResistance = false;
            acidResistance = false;
        }



        //caso de errado deleta at� as chaves da fun��o.



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
        DeathMenu.SetActive(true);
        transform.position = FindObjectOfType<ItemScript>().RespawnPoint;
        FindObjectOfType<PlayerMoviment>().speed = 0f;
        FindObjectOfType<PlayerMoviment>().jumpingPower = 0f;
    }
}
