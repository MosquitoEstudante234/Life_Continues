using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ItemScript : MonoBehaviour

{
    public Text scoreTxt;
    public int score;
    public bool passagem, trues;
    public int scorecomp;
    private int scoremax = 3;
    private GameObject currentTeleporter;
    public static int level = 0;





    private void Start()
    {
        scoremax = 3;
        score = 0;
        scorecomp = 3;
        trues = true;
    }

    // rato gordo gang gang
    private void Update()
    {
        scoreTxt.text = score.ToString();
        if (score == scoremax)
        {
            passagem = true;
        }
       if (Input.GetKeyDown(KeyCode.E))
       {
         if (currentTeleporter != null && passagem == true && score == scoremax)
         {
            transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
                level++;
                SavePlayer();
         }
       }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("cena1");
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.CompareTag("Coletavel") == true)
        {
            score = score + 1;
            Destroy(col.gameObject);
        }
        if (passagem == true && score == scoremax && col.CompareTag("Porta"))
        {
            print("hahahas");
          
        }

            if (col.CompareTag("Mortis") == true)
            {

                SceneManager.LoadScene("cena1");
            }
            if (col.CompareTag("Voides") == true)
            {

                SceneManager.LoadScene("cena1");
            }
          
           if (col.CompareTag("Porta"))
           {
            currentTeleporter = col.gameObject;
           }
         if (col.CompareTag("StatusRemover") == true)
            {

                scoremax += 3;
            }
         if (col.CompareTag("Trofeu") == true)
            {

                SceneManager.LoadScene("cena1");
            }
    }

     private void OnTriggerExit2D(Collider2D col)
     {
       if (col.CompareTag("Porta"))
        {
            if (col.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
            }
        }
     }
      public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        level = data.level;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
    }

}

