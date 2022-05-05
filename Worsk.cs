using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worsk : MonoBehaviour
{
    public int X;
    public int y;
    public int z;
    void Update()
    {
        X = UnityEngine.Random.Range(0, 255);
        y = X + UnityEngine.Random.Range(0, 255);
        z = y + UnityEngine.Random.Range(0, 255);
    }
    
}
