using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    public float timeLeft = 120f;
    private float timeTime = 120f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = timeLeft.ToString();
        }
        else
        {
            timeLeft = timeTime;
            timerText.text = timeLeft.ToString();
        }


    }
    
    
}
