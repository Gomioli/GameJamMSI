using UnityEngine;

public class TriggerVroom : MonoBehaviour
{
    [SerializeField] private 
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trail"))
        {
            foreach (MeshRenderer mr in GetComponentsInChildren<MeshRenderer>())
            {
                mr.enabled = false;
            }
        }
    }
    
}
