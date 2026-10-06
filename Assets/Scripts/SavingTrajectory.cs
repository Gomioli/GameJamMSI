using System;
using UnityEngine;
using System.Collections.Generic;

public class SavingTrajectory : MonoBehaviour
{
    public List<float> positionX = new List<float>();
    public List<float> positionY = new List<float>();
    public List<float> positionZ = new List<float>();
    

    void Update()
    {
       positionX.Add(transform.position.x);
       positionY.Add(transform.position.y);
       positionZ.Add(transform.position.z);
       
       print(positionX);
       print(positionY);
       print(positionZ);
    }
}
