using UnityEngine;

public class VehiculeController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Rigidbody vehiculeRigidbody;
    
    
    void Update()
    {
        // Avancée automatique du véhicule
        vehiculeRigidbody.AddForce(Vector3.forward * moveSpeed);
    }
}
