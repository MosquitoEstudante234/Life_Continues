using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalaFinal : MonoBehaviour
{
    public GameObject Room;
    public GameObject Fader;

    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Room"))
        {
            transform.position = Room.transform.position;
            Fader.SetActive(true);
        }
    }
    
}
