using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;
using UnityEngine;

public class ApplydBGainExtern : MonoBehaviour
{
    public float dBGain = 0;

    [DllImport("MyNativeAudioPlugin")]
    public static extern void applyGain(float[] data, int numSamples, float gain);


    private void OnAudioFilterRead(float[] data, int channels)
    {

        float LinGain = Mathf.Pow(10.0f, dBGain / 20.0f);

        applyGain(data, data.Length, LinGain);

    }

}
