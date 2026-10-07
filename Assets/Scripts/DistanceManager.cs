using TMPro;
using UnityEngine;

public class DistanceManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI distanceText;
    
    [SerializeField] private VehiculeController vehicleController;
    [SerializeField] private Timer timer;

    public float distanceFloat;
    public int distanceInt;
    

    void Start()
    {
        distanceText.text = "0";
        
        distanceFloat = float.Parse(distanceText.text);
    }


    void Update()
    {
        CalculateDistance();
    }

    private void CalculateDistance()
    {
        if (!timer.isFinished)
        {
            distanceFloat += vehicleController.vehiculeRigidbody.velocity.magnitude * Time.deltaTime;
            distanceInt = Mathf.RoundToInt(distanceFloat);
            distanceText.text = distanceInt.ToString();
        }
            
    }
    
}
