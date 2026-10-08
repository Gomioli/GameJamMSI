using UnityEngine;

public class FailManager : MonoBehaviour
{
    
    [SerializeField] private GameObject vroom;

    
    void Update()
    {
        
    }
    
    
    // Ca c'est juste la morte lorsqu'on touche un trail
    private void OnCollisionEnter(Collision collision)
    { 
        if (collision.gameObject == vroom)
        {
            vroom.GetComponentInChildren<MeshRenderer>().enabled = true;
        }
            
    }
    
}
