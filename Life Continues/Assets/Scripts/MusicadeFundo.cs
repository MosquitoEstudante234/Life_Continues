using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicadeFundo : MonoBehaviour
{
   public GameObject Profundezas, Deserto, Fogo, Acido, Castelo;
  
   public void OnTriggerEnter2D(Collider2D col)
   {
     if (col.CompareTag("BiomaProfundezas"))
     {
       Profundezas.SetActive(true);
     }
   
     if (col.CompareTag("BiomaDeserto"))
     {
       Deserto.SetActive(true);
     }
 
     if (col.CompareTag("BiomaFogo"))
     {
       Fogo.SetActive(true);
     }
 
      if (col.CompareTag("BiomaAcido"))
     {
       Acido.SetActive(true);
     }
  
      if (col.CompareTag("BiomaCastelo"))
     {
       Castelo.SetActive(true);
     }
   }
    public void OnTriggerExit2D(Collider2D col)
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
    
      if (col.CompareTag("BiomaAcido"))
     {
       Acido.SetActive(false);
     }
  
      if (col.CompareTag("BiomaCastelo"))
     {
       Castelo.SetActive(false);
     }
    }
}
