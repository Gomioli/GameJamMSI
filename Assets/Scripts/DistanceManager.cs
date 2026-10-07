using TMPro;
using UnityEngine;

public class DistanceManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI distanceParcourueText;
    
    [SerializeField] private VehiculeController vehicleController;
    [SerializeField] private Timer timer;

    public float distanceParcourueFloat;
    public int distanceParcourueInt;
    

    void Start()
    {
        distanceParcourueText.text = "0";
        
        distanceParcourueFloat = float.Parse(distanceParcourueText.text);
    }


    void Update()
    {
        CalculateDistance();
    }

    private void CalculateDistance()
    {
        if (!timer.isFinished)
        {
            distanceParcourueFloat += vehicleController.vehiculeRigidbody.linearVelocity.magnitude * Time.deltaTime;
            distanceParcourueInt = Mathf.RoundToInt(distanceParcourueFloat);
            distanceParcourueText.text = distanceParcourueInt.ToString();
        }
            
    }
    
}
