using UnityEngine;
public class GenNoise : MonoBehaviour
{


    System.Random rand = new System.Random();

    void OnAudioFilterRead(float[] data, int channels)
    {
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = 0.1f*(float)(rand.NextDouble());
        }
    }
}