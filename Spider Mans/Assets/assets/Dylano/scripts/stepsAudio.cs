using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stepsAudio : MonoBehaviour
{
    public AudioSource stepsound;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)) 
        {
            stepsound.Play();
        }
        if(Input.GetKeyUp(KeyCode.W))   
        {
            stepsound.Stop();
        }

    }
     void Stopsound()
    {
        
    }
}
