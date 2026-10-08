using UnityEngine;

public class EndingTrigger : MonoBehaviour
{
    [SerializeField] private GameObject vehicule;

    [SerializeField] private IterationEnding iterationEnding;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == vehicule)
        {
            //iterationEnding.FIN;
        }
    }
    
    
    
}
