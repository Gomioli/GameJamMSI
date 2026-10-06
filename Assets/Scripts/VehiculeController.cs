using UnityEngine;

public class VehiculeController : MonoBehaviour
{
    [SerializeField] private float spinSpeed = 2f;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float brakeForce = 1f;
    
    [SerializeField] private Rigidbody vehiculeRigidbody;
    
    
    
    void Update()
    {
        // Avancée automatique du véhicule
        vehiculeRigidbody.AddForce(transform.forward * moveSpeed);
        
        // Freinage du véhicule
        Braking();
        
        // Tourner le véhicule
        Spining();
    }

    private void Braking()
    {
        if (Input.GetKey(KeyCode.S))
        {
            vehiculeRigidbody.linearDamping = brakeForce;
        }
        else
        {
            vehiculeRigidbody.linearDamping = 0;
        }
    }

    private void Spining()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Quaternion targetRotation = Quaternion.Euler(0, -spinSpeed * Time.deltaTime, 0);
            vehiculeRigidbody.MoveRotation(vehiculeRigidbody.rotation * targetRotation);
            print("Tu tournes");
        }
    }
}
