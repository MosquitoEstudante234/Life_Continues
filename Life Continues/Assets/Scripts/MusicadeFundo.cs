using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicadeFundo : MonoBehaviour
{
   public GameObject Profundezas, Deserto, Fogo, Castelo, Gelo, Final;
  
   public void OnTriggerEnter2D(Collider2D col)
   {
     if (col.CompareTag("BiomaProfundezas"))
     {
            Final.SetActive(false);
            Gelo.SetActive(false);
            Castelo.SetActive(false);
            Fogo.SetActive(false);
            Deserto.SetActive(false);
            Profundezas.SetActive(true);
        }
   
     if (col.CompareTag("BiomaDeserto"))
     {
            Final.SetActive(false);
            Gelo.SetActive(false);
            Castelo.SetActive(false);
            Fogo.SetActive(false);
            Deserto.SetActive(true);
            Profundezas.SetActive(false);
        }
 
     if (col.CompareTag("BiomaFogo"))
     {
            Final.SetActive(false);
            Gelo.SetActive(false);
            Castelo.SetActive(false);
            Fogo.SetActive(true);
            Deserto.SetActive(false);
            Profundezas.SetActive(false);
        }

      if (col.CompareTag("BiomaCastelo"))
     {
            Final.SetActive(false);
            Gelo.SetActive(false);
            Castelo.SetActive(true);
            Fogo.SetActive(false);
            Deserto.SetActive(false);
            Profundezas.SetActive(false);
        }
    
        if (col.CompareTag("BiomaGelo"))
        {
            Final.SetActive(false);
            Gelo.SetActive(true);
            Castelo.SetActive(false);
            Fogo.SetActive(false);
            Deserto.SetActive(false);
            Profundezas.SetActive(false);
        }
       
        if (col.CompareTag("BiomaFinal"))
        {
            Final.SetActive(true);
            Gelo.SetActive(false);
            Castelo.SetActive(false);
            Fogo.SetActive(false);
            Deserto.SetActive(false);
            Profundezas.SetActive(false);
        }
    }
    /*public void OnTriggerExit2D(Collider2D col)
    {
     if (col.CompareTag("BiomaProfundezas"))
     {
       Profundezas.SetActive(false);
     }
   
     if (col.CompareTag("BiomaDeserto"))
     {
       Deserto.SetActive(false);
     }
    
     if (col.CompareTag("BiomaFogo"))
     {
       Fogo.SetActive(false);
     }
  
      if (col.CompareTag("BiomaCastelo"))
     {
       Castelo.SetActive(false);
     }
    
        if (col.CompareTag("BiomaGelo"))
        {
            Gelo.SetActive(false);
        }
      
        if (col.CompareTag("BiomaFinal"))
        {
            Final.SetActive(false);
        }
    }*/
}
