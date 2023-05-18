# audio-in-unity
Overview of methods for manipulating audio in Unity

The presentation is available as a pdf in the repository. I presented a list of very simple Unity scenes, each representing one topic in the tutorial: 

1. Basic audio functionalities:

   ScaleOnVolume.cs - script to change the size of the object when modifying the volume /n
   SinusMovement.cs - script to create a circular movement of an object /n
   PitchOnMovement.cs - script to change pitch parameter depending on the movement
   
2. OnAudioFilterRead()
   ScaleOnLoudness.cs - script to make the size of the object follow instantaneous signal level
   GenNoise.cs - script to generate noise using OnAudioFilterRead()
   ApplydBGain.cs - script to apply gain in dB to the sound source
3. Native Code 
   ApplydBGainExtern.cs - script to apply gain in dB using external function loaded from a c++ library
4. Unity Audio Plugins 
   Plugins are available in folder NativeCode
5. Spatializers
   MovePlayerKeys.cs - script defining first person camera movement with arrow keys
   SoundOnOff.cs - script switching on and off the sound when clicking on the source
6. ML Inference 
   LoadMNIST.cs - script to demonstrate how to use the Baracuda inference in Unity


