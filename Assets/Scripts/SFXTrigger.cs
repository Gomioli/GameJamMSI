using UnityEngine;
using UnityEngine.Audio;

public class AccelerationTrigger : MonoBehaviour
{
    public AudioClip sonBagnole; 
    void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(sonBagnole);
    }
}
