using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaSal : MonoBehaviour
{
    public Transform Point_Aum, Point_bum, Point_cum, Point_dum;
    public int speed;
    Vector2 targetPosi;


    void Start()
    {
        targetPosi = Point_bum.position;
    }

    // Update is called once per frame
    void Update()
    {
        //  if (Vector2.Distance(transform.position, Point_A.position) < 1f) targetPos = Point_b.position;

        //   if (Vector2.Distance(transform.position, Point_b.position) < 1f) targetPos = Point_A.position;

        //  transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);


    }
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && PlayerHealth.fireResistance == true)
        {
            collision.transform.SetParent(this.transform);
            if (Vector2.Distance(transform.position, Point_Aum.position) < 1f) targetPosi = Point_bum.position;

            if (Vector2.Distance(transform.position, Point_bum.position) < 1f) targetPosi = Point_Aum.position;

            transform.position = Vector2.MoveTowards(transform.position, targetPosi, speed * Time.deltaTime);
            
        }

        if (collision.CompareTag("Player") && PlayerHealth.iceResistance == true)
        {
            collision.transform.SetParent(this.transform);
            if (Vector2.Distance(transform.position, Point_cum.position) < 1f) targetPosi = Point_dum.position;

            if (Vector2.Distance(transform.position, Point_dum.position) < 1f) targetPosi = Point_cum.position;

            transform.position = Vector2.MoveTowards(transform.position, targetPosi, speed * Time.deltaTime);
            
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }

}