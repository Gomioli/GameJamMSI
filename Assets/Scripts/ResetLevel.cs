using System.Collections;
using UnityEngine;

public class ResetLevel : MonoBehaviour
{
    [SerializeField] private GameObject vehiculePrefab;
    [SerializeField] private Transform vehiculePositionStart;
    [SerializeField] private Transform trailPositionStart;
    
    [SerializeField] private IterationEnding iterationEnding;

    public int decompteDemarrage = 3;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }
    }

    public void Reset()
    {
        Destroy(vehiculePrefab);
        StartCoroutine(DemarrageVehicule());
        Instantiate(vehiculePrefab, vehiculePositionStart.position, vehiculePositionStart.rotation);
    }

    private IEnumerator DemarrageVehicule()
    {
        yield return new WaitForSeconds(decompteDemarrage);
    }

    
    
    
}
