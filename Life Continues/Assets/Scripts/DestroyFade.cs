using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFade : MonoBehaviour
{
    public GameObject FadeGamer;
    
    public void DestryFade()
    {
        Destroy(FadeGamer); 
    }
}
