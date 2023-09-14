using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaPas : MonoBehaviour
{
    public Transform Point_Ados, Point_bdos;
    public int speed;
    Vector2 targetPose;


    void Start()
    {
        targetPose = Point_bdos.position;
    }

    // Update is called once per frame
    void Update()
    {
          if (Vector2.Distance(transform.position, Point_Ados.position) < 1f) targetPose = Point_bdos.position;

          if (Vector2.Distance(transform.position, Point_bdos.position) < 1f) targetPose = Point_Ados.position;

          transform.position = Vector2.MoveTowards(transform.position, targetPose, speed * Time.deltaTime);


    }
   

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }

}
