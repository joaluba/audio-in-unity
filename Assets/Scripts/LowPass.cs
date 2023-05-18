using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;
using UnityEngine;

public class LowPass : MonoBehaviour
{
    public float cutoffFrequency = 100;
    private float SampleRate;
    private int FrameLength;
    [DllImport("MyNativeAudioPlugin2")]
    public static extern void applyLowPassFilter(float[] data, int numSamples, float cutoffFrequency, float sampleRate);

    private void Awake()
    {
        FrameLength = AudioSettings.GetConfiguration().dspBufferSize;
        SampleRate = AudioSettings.outputSampleRate;

    }

    private void OnAudioFilterRead(float[] data, int channels)
    {
        int numSamples = data.Length / channels;

        // De-interleave the channels
        float[][] channelBuffers = new float[channels][];
        for (int channel = 0; channel < channels; channel++)
        {
            channelBuffers[channel] = new float[numSamples];

            for (int i = 0; i < numSamples; i++)
            {
                int index = i * channels + channel;
                channelBuffers[channel][i] = data[index];
            }
        }
  
        for (int channel = 0; channel < channels; channel++)
        {

            applyLowPassFilter(channelBuffers[channel], FrameLength, cutoffFrequency, SampleRate);
        }

        // Interleave the channels back into the data array
        for (int channel = 0; channel < channels; channel++)
        {
            for (int i = 0; i < numSamples; i++)
            {
                int index = i * channels + channel;
                data[index] = channelBuffers[channel][i];
            }
        }
    }
}
