using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Voides : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.CompareTag("Player") == true)
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene("cena1");

        }

    }

}
