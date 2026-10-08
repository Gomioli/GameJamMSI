using System;
using System.Collections;
using UnityEngine;

public class EndingTrigger : MonoBehaviour
{
    [SerializeField] private GameObject vehicule;

    [SerializeField] private IterationEnding iterationEnding;

    private float debutTrigger = 10f;
    public bool hasFinished = false;


    private void Start()
    {
        StartCoroutine(AttenteTrigger());
    }
    
    

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == vehicule)
        {
            hasFinished = true;
        }
    }


    private IEnumerator AttenteTrigger()
    {
        yield return new WaitForSeconds(debutTrigger);
    }
    
    
    
    
    
}
