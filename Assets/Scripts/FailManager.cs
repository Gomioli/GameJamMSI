using UnityEngine;

public class FailManager : MonoBehaviour
{

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
    
}
