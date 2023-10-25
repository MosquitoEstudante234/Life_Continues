using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VoltarPlataformas : MonoBehaviour
{
    public GameObject Plataforma1, Plataforma2, Plataforma3, Plataforma4, Plataforma5, Plataforma6, Plataforma7, Plataforma8;
    public GameObject Player;
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
        if (Player.CompareTag("Button") && Input.GetKeyDown(KeyCode.E))
        {

            Plataforma1.transform.position = new Vector2(0, -141);
            Plataforma2.transform.position = new Vector2(0, -141);
            Plataforma3.transform.position = new Vector2(0, -141);
            Plataforma4.transform.position = new Vector2(0, -141);
            Plataforma5.transform.position = new Vector2(0, -141);
            Plataforma6.transform.position = new Vector2(0, -141);
            Plataforma7.transform.position = new Vector2(0, -141);
            Plataforma8.transform.position = new Vector2(0, -141);
            Debug.Log("Jose");
        }

    }
}
