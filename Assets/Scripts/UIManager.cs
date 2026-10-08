using System.Collections;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] public Canvas ecranFin;
    //[SerializeField] private TextMeshProUGUI distancePrecedentText;
    [SerializeField] private TextMeshProUGUI distanceActuelleText;
    [SerializeField] private TextMeshProUGUI distanceTotalText;

    //[SerializeField] private TextMeshProUGUI PrecedenteDistanceText;
    //[SerializeField] private TextMeshProUGUI ActuelleDistanceText;   Je ne sais pas si j'en aurai besoin, mais je le mets là pour y penser au cas où
    
    [SerializeField] private TextMeshProUGUI victoireDefaiteText;

    [SerializeField] private Button recommencerButton;
    [SerializeField] private Button prochaineCourseButton;
    
    //public int distancePrecedentInt;
    public int distanceActuelleInt;
    public float distanceActuelleFloat;
    public int distanceTotalInt;
    public float distanceTotalFloat;
    
    [SerializeField] private float speedWrite = 3f;
    
    private Coroutine animCoroutine;
    private bool animationLancee;
    

    [SerializeField] private DistanceManager distanceManager;
    [SerializeField] private IterationEnding iterationEnding;
    [SerializeField] private EndingTrigger endingTrigger;
    [SerializeField] private Timer timer;


    
    void Start()
    {
        distanceActuelleInt = int.Parse(distanceActuelleText.text);
        //distancePrecedentInt = int.Parse(distancePrecedentText.text);
        
        ecranFin.enabled = false;
        
    }
    
    void Update()
    {
        if (endingTrigger.isPassed == 2 && !animationLancee)
        {
            animationLancee = true;
            HasWin();
            ShowUI();
            LancerAnimation();
        }
        else if (timer.isFinished && !animationLancee)
        {
            animationLancee = true;
            HasWin();
            ShowUI();
        }
    }
    
    private void ShowUI()
    {
        // if (iterationEnding.iterationCount == 1)
        // {
        //     distancePrecedentText.enabled = false;
        //     PrecedenteDistanceText.enabled = false;
        // }
        ecranFin.enabled = true;
    }

    
    public void LancerAnimation()
    {
        if (animCoroutine != null) StopCoroutine(animCoroutine);
        animCoroutine = StartCoroutine(IncreaseDistanceActuelleAndTotal());
    }
    
    
    
    // Cette fonction sert à faire le compte de la distance actuelle. Donc de 0 à la distance parcourue à cette run
    private IEnumerator IncreaseDistanceActuelleAndTotal()
    {
        float cible = distanceManager.distanceParcourueInt;
        
        while (distanceActuelleFloat < cible)
        {
            distanceActuelleFloat += Time.deltaTime * speedWrite;
            distanceActuelleFloat = Mathf.Min(distanceActuelleFloat, cible);
            distanceActuelleInt = Mathf.RoundToInt(distanceActuelleFloat);
            distanceActuelleText.text = distanceActuelleInt.ToString();
            yield return null;
        }
        
        while (distanceActuelleFloat > 0f)
        {
            float step = Mathf.Min(Time.deltaTime * speedWrite, distanceActuelleFloat);

            distanceActuelleFloat -= step;
            distanceTotalFloat += step;

            distanceActuelleInt = Mathf.RoundToInt(distanceActuelleFloat);
            distanceTotalInt = Mathf.RoundToInt(distanceTotalFloat);

            distanceActuelleText.text = distanceActuelleInt.ToString();
            distanceTotalText.text = distanceTotalInt.ToString();
            yield return null;
        }
    
    }

    
    // Cette fonction va servir pour savoir quoi afficher dans ShowUI
    private void HasWin() 
    {
        if (endingTrigger.isPassed == 2) // A passer la ligne d'arrivee
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
