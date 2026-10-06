using System;
using UnityEngine;
using System.Collections.Generic;

public class IterationEnding : MonoBehaviour
{
    [SerializeField] private Timer timer;
    [SerializeField] private GameObject trail;

    [SerializeField] private VehiculeController vehiculeController;
    
    [SerializeField] private List<GameObject> trails = new List<GameObject>();

    private void Update()
    {
        if (timer.timeLeft <= 0)
        {
            trails.Add(trail);
            vehiculeController.vehiculeRigidbody.velocity = new Vector3(0f, 0f, 0f);
        }
    }
}
