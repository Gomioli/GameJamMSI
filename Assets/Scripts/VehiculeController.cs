using UnityEngine;

public class VehiculeController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Rigidbody vehiculeRigidbody;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vehiculeRigidbody.AddRelativeForce(Vector3.forward * moveSpeed);
    }
}
