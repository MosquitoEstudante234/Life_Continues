using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformasqueCaem : MonoBehaviour
{
    public bool EstaGamer;
    public Transform Point_Aum, Point_bum;
    public int speed;
    Vector2 targetPosi;
    public Vector3 RespawnPoint;


    void Start()
    {
        targetPosi = Point_Aum.position;
        RespawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!EstaGamer)
        {
            if (Vector2.Distance(transform.position, Point_Aum.position) < 0.1f)
            {
              //  targetPosi = Point_bum.position;
                transform.position = RespawnPoint;
                EstaGamer = true;
                targetPosi = Point_Aum.position;

            }
           /* if (Vector2.Distance(transform.position, Point_bum.position) < 0.1f) {
                targetPosi = Point_Aum.position;
                    EstaGamer = true;
            }*/
            transform.position = Vector2.MoveTowards(transform.position, targetPosi, speed * Time.deltaTime);

        } 


    }
    private void OnTriggerExit2D(Collider2D collision)
    {

          if (collision.CompareTag("Player"))
          {
             EstaGamer = false;
            
          }
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }

        /*  if (collision.CompareTag("Player") && PlayerHealth.iceResistance == true)
           {
               collision.transform.SetParent(this.transform);
               if (Vector2.Distance(transform.position, Point_cum.position) < 1f) targetPosi = Point_dum.position;

               if (Vector2.Distance(transform.position, Point_dum.position) < 1f) targetPosi = Point_cum.position;

               transform.position = Vector2.MoveTowards(transform.position, targetPosi, speed * Time.deltaTime);

         } */


    }


   /* private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    } */

}
