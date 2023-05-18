using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Barracuda;

public class LoadMNIST : MonoBehaviour
{


    public NNModel ONNXmodel;
    private IWorker worker;
    public Texture2D MNISTsample;

    void Start()
    {

        worker = ONNXmodel.CreateWorker();
        int batch = 1;
        int height = 28;
        int width = 28;
        int channels = 1;
     

        Tensor input = new Tensor(batch, height, width, channels);

        for (int x = 0; x < height; x++)
        {
            for (int y = 0; y < height; y++)
            {
                input[0, x, y, 0] = MNISTsample.GetPixel(x, y).r;
                print(MNISTsample.GetPixel(x, y).r);
            }
                
        }


        // execute neural network with specific input and get results back
        var output = worker.Execute(input).PeekOutput();

        for (int i=0; i<output.length; i++)
        {
            Debug.Log("Probability for "+i+ "="+ output[i]);

        }


    }


}
