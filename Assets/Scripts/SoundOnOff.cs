using UnityEngine;
using System.Collections;

public class SoundOnOff : MonoBehaviour
{

    private bool clicked = false;


    void OnMouseDown()
    {
      
        ClickSource();
       
    }
  

    public void ClickSource()
    {
        if (clicked == false)
        {
            GetComponent<AudioSource>().mute = false;
            GetComponent<Renderer>().material.color = Color.green;
            clicked = true;
        }
        else if (clicked == true)
        {
            GetComponent<AudioSource>().mute = true;
            GetComponent<Renderer>().material.color = Color.white;
            clicked = false;
        }
    }


}
    