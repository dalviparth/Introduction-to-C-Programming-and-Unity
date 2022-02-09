/* Problem – Declaring and Using Constants and Variables
Create a new 2D Unity project named Exercise5. Add a scenes folder and save the current scene as scene0. Add a scripts folder and add a new C# script named PrintPercent. 

Open the script, fill in the comment near the top of the script, and delete the Update method.Add the following code to the Start method:

Declare a constant named MaxScore of type int and assign it a value of 100.
Declare a variable named score of type int and assign it a value between 0 and 100.
Declare a variable named percent of type float and store the percent calculated by dividing score by MaxScore.
Remember how integer division works in C# and use type casting as appropriate.
Print the percent in the Unity Console window. The percent you print should be between 0% and 100%.
Attach the script to the Main Camera in the scene and run the game to see the output in the Console window.*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintPercent : MonoBehaviour
{
    public static int MaxScore = 100;
    void Start()
    {
        int score = 50;
        float percent = (float)score/MaxScore;

        print(percent);
    }
}
