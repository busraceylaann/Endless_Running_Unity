using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -3.06f;
    public static float rightSide = 3.06f;
    public  float internalLeft;
    public  float internalRight;


    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
        
    }
}
