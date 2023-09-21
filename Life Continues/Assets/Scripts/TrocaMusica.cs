using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaMusica : MonoBehaviour
{

    public AudioClip NewTrack;
    private AudioManager Managersons;

    void Start()
    {
        Managersons = FindObjectOfType<AudioManager>();
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (col.CompareTag("Player"))
            {
                if (NewTrack != null)
                    Managersons.ChangeAudiogamer(NewTrack);
            }
        }
    }
}