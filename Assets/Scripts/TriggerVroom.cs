using UnityEngine;

public class TriggerVroom : MonoBehaviour
{
    [SerializeField] private VehiculeController vehiculeController;
    [SerializeField] private UIManager uiManager;

    public bool isDead = false;
    
    public void OnTriggerEnter(Collider other)
    {
        
        print("TOUCHE");
        if (other.gameObject.CompareTag("Trail"))
        {
            
            foreach (MeshRenderer mr in GetComponentsInChildren<MeshRenderer>())
            {
                mr.enabled = false;
            }
            vehiculeController.enabled = false;
            uiManager.enabled = true;
            isDead = true;
            Debug.Log(isDead);
        }
    }
    
}
