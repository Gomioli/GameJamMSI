using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI timerText;
    
    [SerializeField] private IterationEnding iterationEnding;
    
    public float timeLeft = 120f;
    public int timeLeftInt;
    public bool isFinished = false;
    
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
            timeLeftInt = Mathf.RoundToInt(timeLeft);
            timerText.text = timeLeftInt.ToString();
        }
        else if (timeLeft <= 0 && iterationEnding.trailAdd == false) 
        {
            timeLeft = 0;
            timerText.text = timeLeft.ToString();
            timeLeftInt = Mathf.RoundToInt(timeLeft);
            iterationEnding.AddTrail();
            isFinished = true;
        }
    }
    
    
}
