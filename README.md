# audio-in-unity
Overview of methods for manipulating audio in Unity

The presentation is available as a pdf in the repository. I presented a list of very simple Unity scenes, each representing one topic in the tutorial: 

1. Basic audio functionalities: <br /> 
   ScaleOnVolume.cs - script to change the size of the object when modifying the volume <br /> 
   SinusMovement.cs - script to create a circular movement of an object <br /> 
   PitchOnMovement.cs - script to change pitch parameter depending on the movement <br /> 
   
2. OnAudioFilterRead()<br /> 
   ScaleOnLoudness.cs - script to make the size of the object follow instantaneous signal level<br /> 
   GenNoise.cs - script to generate noise using OnAudioFilterRead()<br /> 
   ApplydBGain.cs - script to apply gain in dB to the sound source<br /> 
   
3. Native Code <br /> 
   ApplydBGainExtern.cs - script to apply gain in dB using external function loaded from a c++ library<br /> 
   
4. Unity Audio Plugins <br /> 
   Plugins are available in folder NativeCode <br /> 
   
5. Spatializers <br /> 
   MovePlayerKeys.cs - script defining first person camera movement with arrow keys <br /> 
   SoundOnOff.cs - script switching on and off the sound when clicking on the source <br /> 
   
6. ML Inference <br /> 
   LoadMNIST.cs - script to demonstrate how to use the Baracuda inference in Unity <br /> 


