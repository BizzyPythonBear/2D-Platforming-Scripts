using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSFX : MonoBehaviour {

    public AudioSource JumpNoise;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {

        if(Input.GetKeyDown(KeyCode.Space)){
            JumpNoise.Play();
        }
    }
}

//Simple script I use to play a sound effect whenever you hit space, like for when a character jumps.
