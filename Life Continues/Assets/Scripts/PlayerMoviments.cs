using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviments : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Movimento()
    {
       FindObjectOfType<PlayerMoviment>().speed = 20f;
        FindObjectOfType<PlayerMoviment>().jumpingPower = 18f;
    }
}
