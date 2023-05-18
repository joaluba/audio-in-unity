using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;


public class DeinterleaveTest : MonoBehaviour
{

    private int FrameLength;
    private int SampleRate;
    float[][] ListOfChannelBuffers;

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

        //// Apply different gain to each channel
        //float[] channelGains = { 0.8f, 1.2f, 0.9f }; // Example gain values for each channel

        //for (int channel = 0; channel < channels; channel++)
        //{
        //    for (int i = 0; i < numSamples; i++)
        //    {
        //        channelBuffers[channel][i] *= channelGains[channel];
        //    }
        //}

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



