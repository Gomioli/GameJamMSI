using UnityEngine;

public class VehiculeController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float brakeForce = 1f;
    [SerializeField] private Rigidbody vehiculeRigidbody;
    
    
    
    void Update()
    {
        // Avancée automatique du véhicule
        vehiculeRigidbody.AddForce(Vector3.forward * moveSpeed);
        
        // Freinage du véhicule
        Braking();
    }

    private void Braking()
    {
        //vehiculeRigidbody.AddForce(Vector3.back * brakeForce);
        
        if (Input.GetKey(KeyCode.S))
        {
            vehiculeRigidbody.linearDamping = brakeForce;
        }
        else
        {
            vehiculeRigidbody.linearDamping = 0;
        }

    }
}
