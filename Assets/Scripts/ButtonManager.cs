using JetBrains.Annotations;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private ResetLevel resetLevel;
    [SerializeField] private UIManager uiManager;
    [SerializeField] [NotNull] private VehiculeController vehiculeController;
    
    [SerializeField] private GameObject vehiculePrefab;
    
    public void OnClick()
    {
        resetLevel.Reset();
        uiManager.ecranFin.enabled = false;
        
    }
    
    
    
}
