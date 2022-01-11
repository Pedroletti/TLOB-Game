using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFile : MonoBehaviour
{

    public AudioSource source;
    public AudioClip clip;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            source.PlayOneShot(clip);
        }
    }
}
