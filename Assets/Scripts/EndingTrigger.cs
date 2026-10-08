using System;
using System.Collections;
using UnityEngine;

public class EndingTrigger : MonoBehaviour
{
    [SerializeField] private GameObject vehicule;

    [SerializeField] private IterationEnding iterationEnding;

    private int debutTrigger = 10;
    public bool hasFinished = false;
    public int isPassed = 0;


    private void Start()
    {
        StartCoroutine(AttenteTrigger());
    }
    
    

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //hasFinished = true;
            isPassed++;
        }
    }


    private IEnumerator AttenteTrigger()
    {
        
        yield return new WaitForSeconds(debutTrigger);
        
    }





}
