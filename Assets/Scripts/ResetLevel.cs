using UnityEngine;

public class ResetLevel : MonoBehaviour
{
    [SerializeField] private GameObject Vehicule;
    [SerializeField] private GameObject vroom;
    [SerializeField] private Transform vehiculePositionStart;
    [SerializeField] private Transform trailPositionStart;
    [SerializeField] private EndingTrigger endingTrigger;
    [SerializeField] private DistanceManager distanceManager;
    [SerializeField] private Timer timer;
    
    [SerializeField] private IterationEnding iterationEnding;
    
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.R))
        // {
        //     Reset();
        // }
    }

    public void Reset()
    { 
        Vehicule.transform.position = vehiculePositionStart.position; 
        Vehicule.transform.rotation = vehiculePositionStart.rotation;

        endingTrigger.isPassed = 0;
        
        vroom.GetComponentInChildren<MeshRenderer>().enabled = true;


    }

    
    
    
}
