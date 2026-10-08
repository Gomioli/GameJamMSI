using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Canvas ecranFin;
    [SerializeField] private TextMeshProUGUI distancePrecedentText;
    [SerializeField] private TextMeshProUGUI distanceActuelleText;

    [SerializeField] private TextMeshProUGUI PrecedenteDistanceText;
    //[SerializeField] private TextMeshProUGUI ActuelleDistanceText;   Je ne sais pas si j'en aurai besoin, mais je le mets là pour y penser au cas où
    
    [SerializeField] private TextMeshProUGUI victoireDefaiteText;

    [SerializeField] private Button recommencerButton;
    [SerializeField] private Button prochaineCourseButton;
    
    public int distancePrecedentInt;
    public int distanceActuelleInt;

    [SerializeField] private DistanceManager distanceManager;
    [SerializeField] private IterationEnding iterationEnding;
    [SerializeField] private EndingTrigger endingTrigger;
    [SerializeField] private Timer timer;


    
    void Start()
    {
        distanceActuelleInt = int.Parse(distanceActuelleText.text);
        distancePrecedentInt = int.Parse(distancePrecedentText.text);
        
        ecranFin.enabled = false;
        
    }
    
    void Update()
    {
        if (timer.isFinished) // Je vais devoir changer ça vu que maintenant c'est en FINISSANT UN TOUR
        {
            HasWin();
            ShowUI();
            IncreaseDistanceActuelle();
        }
    }
    
    private void ShowUI()
    {
        if (iterationEnding.iterationCount == 1)
        {
            distancePrecedentText.enabled = false;
            PrecedenteDistanceText.enabled = false;
        }
        ecranFin.enabled = true;
    }

    
    // Cette fonction sert à faire le compte de la distance actuelle. Donc de 0 à la distance parcourue à cette run
    private void IncreaseDistanceActuelle()
    {
        while (distanceManager.distanceParcourueInt != distanceActuelleInt)
        {
            distanceActuelleInt += 1;
            distanceActuelleText.text = distanceActuelleInt.ToString();
        }
    }

    
    // Cette fonction va servir pour savoir quoi afficher dans ShowUI
    private void HasWin() 
    {
        if (endingTrigger.hasFinished) // A passer la ligne d'arrivee
        {
            victoireDefaiteText.text = "BRAVO";
            recommencerButton.enabled = false;
            ColorBlock cbRecommencer = recommencerButton.colors;
            cbRecommencer.normalColor = Color.gray;
            recommencerButton.colors = cbRecommencer;
        }
        else if (timer.isFinished) // Le temps s'est ecoule
        {
            victoireDefaiteText.text = "AIE...";
            prochaineCourseButton.enabled = false;
            ColorBlock cbProchaineCourse = prochaineCourseButton.colors;
            cbProchaineCourse.normalColor = Color.gray;
            prochaineCourseButton.colors = cbProchaineCourse;
        }
    }
    
    
    
    
    
    
    
    
    
    
    
    // private void HasWin() 
    // {
    //     if (iterationEnding.iterationCount == 1)
    //     {
    //         if (distanceManager.distanceParcourueInt >= distancePrecedentInt)
    //         {
    //             victoireDefaiteText.text = "BRAVO";
    //             recommencerButton.enabled = false;
    //             ColorBlock cbRecommencer = recommencerButton.colors;
    //             cbRecommencer.normalColor = Color.gray;
    //             recommencerButton.colors = cbRecommencer;
    //         }
    //         else
    //         {
    //             victoireDefaiteText.text = "AIE...";
    //             prochaineCourseButton.enabled = false;
    //             ColorBlock cbProchaineCourse = prochaineCourseButton.colors;
    //             cbProchaineCourse.normalColor = Color.gray;
    //             prochaineCourseButton.colors = cbProchaineCourse;
    //         }
    //     }
    // }
    
    
}
