using UnityEngine;

public class FailManager : MonoBehaviour
{
    
    [SerializeField] private GameObject vroom;

    
    void Update()
    {
        
    }
    
    
    // Ca c'est juste la morte lorsqu'on touche un trail
    // private void OnCollisionEnter(Collision collision)
    // { 
    //     if (collision.gameObject.CompareTag("PlayerCollider"))
    //     {
    //         collision.gameObject.GetComponentInChildren<MeshRenderer>().enabled = true;
    //     }
    //         
    // }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.gameObject.CompareTag("PlayerCollider"))
    //     {
    //         other.gameObject.GetComponentInChildren<MeshRenderer>().enabled = true;
    //         Debug.Log(other.gameObject.name);
    //         Debug.Log("FAUTPASTOUCHE");
    //     }
    // }
    
}
