using UnityEngine;
using System.Collections.Generic;

public class TrailSpawner : MonoBehaviour
{
    [SerializeField] GameObject trailPrefab;
    [SerializeField] List<GameObject> trails;

    private Vector3 trailPosition;

    private void Start()
    {
        trailPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
    
    
    private void Update()
    {
        Instantiate(trailPrefab, trailPosition, transform.rotation);
        //trails.Add(Instantiate(trailPrefab, transform.position, transform.rotation));
        
        
    }
}
