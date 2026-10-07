using UnityEngine;

public class ResetLevel : MonoBehaviour
{
    [SerializeField] private GameObject Vehicule;
    [SerializeField] private Transform vehiculePositionStart;
    [SerializeField] private Transform trailPositionStart;
    
    [SerializeField] private IterationEnding iterationEnding;
    
    void Update()
    {
        
    }

    public void Reset()
    {
        if (iterationEnding.iterationCount > 0)
        {
            Vehicule.transform.position = vehiculePositionStart.position;
            iterationEnding.trails.ForEach(trail =>
                {
                    trail.transform.position = trailPositionStart.position;
                }
            );
        }
    }
    
}
