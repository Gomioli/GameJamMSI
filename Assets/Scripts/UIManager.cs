using TMPro;
using UnityEditor;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Canvas ecranFin;
    [SerializeField] private TextMeshProUGUI distancePrecedentText;
    [SerializeField] private TextMeshProUGUI distanceActuelleText;

    [SerializeField] private Timer timer;
    
    void Start()
    {
        ecranFin.enabled = false;
        
        int distanceActuelleInt = int.Parse(distanceActuelleText.text);
    }
    
    void Update()
    {
        if (timer.isFinished)
        {
            ShowingUI();
            
        }
    }
    
    private void ShowingUI()
    {
        ecranFin.enabled = true;
    }

    
    // Cette fonction sert à faire le compte de la distance actuelle. Donc de 0 à la distance parcourue à cette run
    private void IncreaseDistanceActuelle()
    {
        
    }
    
    
}
