using UnityEngine;

public class EndingTrigger : MonoBehaviour
{
    [SerializeField] private GameObject vehicule;

    [SerializeField] private IterationEnding iterationEnding;
    
    public bool hasFinished = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == vehicule)
        {
            hasFinished = true;
        }
    }
    
    
    
}
