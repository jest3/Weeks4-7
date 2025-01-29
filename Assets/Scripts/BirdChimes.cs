using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdChimes : MonoBehaviour
{
    public AudioSource chimes;
    public AudioClip chimeClip;
    public SpriteRenderer bird;

    // Start is called before the first frame update
    void Start()
    {
        chimes.Play();
    }

    // Update is called once per frame
    void Update()
    {

        if (chimes.isPlaying == true)
        {
            bird.enabled = true;
        }

        if (chimes.isPlaying == false)
        {
            bird.enabled = false;
        }

    }
}
