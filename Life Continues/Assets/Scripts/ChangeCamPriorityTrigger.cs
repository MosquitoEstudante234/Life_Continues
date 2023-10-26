using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ChangeCamPriorityTrigger : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera ActiveCam;
    [SerializeField] CinemachineVirtualCamera UnactiveCam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ActiveCam.Priority = 1;
        UnactiveCam.Priority = 0;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ActiveCam.Priority = 0;
        UnactiveCam.Priority = 1;
    }
}
