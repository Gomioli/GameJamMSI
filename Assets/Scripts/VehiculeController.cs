using UnityEngine;

public class VehiculeController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float brackForce = 1f;
    [SerializeField] private Rigidbody vehiculeRigidbody;
    
    
    
    void Update()
    {
        // Avancée automatique du véhicule
        vehiculeRigidbody.AddForce(Vector3.forward * moveSpeed);
        
        // Freinage du véhicule
        if (Input.GetKey(KeyCode.S))
        {
            Bracking();
        }
    }

    private void Bracking()
    {
        vehiculeRigidbody.AddForce(Vector3.back * brackForce);
    }
}
