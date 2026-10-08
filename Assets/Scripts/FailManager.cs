using UnityEngine;

public class FailManager : MonoBehaviour
{

    
    void Update()
    {
        
    }
    
    
    // Ca c'est juste la morte lorsqu'on touche un trail
    private void OnCollisionEnter(Collision collision)
    { 
        Destroy(collision.gameObject);
    }
    
}
