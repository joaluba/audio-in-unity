using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchOnMove : MonoBehaviour
{
    private float StartPitch;
   
    private float StartHeight;
    private float NowHeight;

    // Update is called once per frame
    void Start()
    {

        StartPitch = this.GetComponent<AudioSource>().pitch;
        StartHeight = this.transform.position.y;

    }
    // Update is called once per frame
    void Update()
    {
        NowHeight = this.transform.position.y;

        var HeightDiff = StartHeight - NowHeight;

        this.GetComponent<AudioSource>().pitch = StartPitch + 0.01f* HeightDiff;

    }
}
