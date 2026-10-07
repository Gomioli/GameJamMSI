using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    
    [SerializeField] private IterationEnding iterationEnding;
    
    public float timeLeft = 120f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimePassing();
    }


    private void TimePassing()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = timeLeft.ToString();
        }
        else if (timeLeft <= 0 && iterationEnding.trailAdd == false) 
        {
            timeLeft = 0;
            timerText.text = timeLeft.ToString();
            iterationEnding.AddTrail();
        }
    }
    
    
}
