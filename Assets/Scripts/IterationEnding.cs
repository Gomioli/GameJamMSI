using System;
using UnityEngine;
using System.Collections.Generic;

public class IterationEnding : MonoBehaviour
{
    [SerializeField] private Timer timer;
    [SerializeField] private GameObject trail;

    public bool trailAdd = false;
    public int iterationCount = 0;

    [SerializeField] private VehiculeController vehiculeController;
    
    [SerializeField] private List<GameObject> trails = new List<GameObject>();

    private void Awake()
    {
        trailAdd = false;
        
    }

    public void AddTrail()
    {
        trails.Add(trail);
        if (vehiculeController != null)
            vehiculeController.enabled = false;
        trailAdd = true;
        iterationCount++;
    }
}
