using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.Audio;

public class sfxTrigger : MonoBehaviour
{
    public ulong moteurBagnole;
    public AudioClip accelerartionBagnole;
    public AudioClip freinBagnole;
    public AudioClip crashBagnole;
    public AudioClip mortBagnole;

    public float intensitePitch = 1f;

    [SerializeField] private GameObject vehicule;
    [SerializeField] private VehiculeController vehiculeController;
    [SerializeField] private TriggerVroom triggerVroom;

    void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(accelerartionBagnole);
        GetComponent<AudioSource>().Play(moteurBagnole);

        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<AudioSource>().PlayOneShot(freinBagnole);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().PlayOneShot(crashBagnole);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<AudioSource>().PlayOneShot(freinBagnole);
        }

        if (triggerVroom.isDead)
        {
            GetComponent<AudioSource>().PlayOneShot(mortBagnole);
        }


        // GetComponent<AudioSource>().Play(moteurBagnole);
        // GetComponent<AudioSource>().pitch = intensitePitch * vehiculeController.vehiculeRigidbody.linearVelocity;
    }
    
}