using UnityEngine;
using System.Collections;

public class ResetLevel : MonoBehaviour
{
    [SerializeField] private GameObject Vehicule;
    [SerializeField] private GameObject vroom;
    [SerializeField] private GameObject trail;
    
    [SerializeField] private TrailRenderer trailRenderer;
    [SerializeField] private Transform vehiculePositionStart;
    [SerializeField] private Transform trailPositionStart;
    
    [SerializeField] private EndingTrigger endingTrigger;
    [SerializeField] private DistanceManager distanceManager;
    [SerializeField] private Timer timer;
    [SerializeField] private UIManager uiManager;
    [SerializeField] private VehiculeController vehiculeController;
    
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
        
        foreach (MeshRenderer mr in vroom.GetComponentsInChildren<MeshRenderer>())
        {
            mr.enabled = true;
        }
        
        trailRenderer.Clear();

        uiManager.ecranFin.enabled = false;

        StartCoroutine(Redemarrage());
        vehiculeController.enabled = true;
    }

    private IEnumerator Redemarrage()
    {
        yield return new WaitForSeconds(3f);
    }
    

    
    
    
}
