using UnityEngine;

public class AcceleratorTrigger : MonoBehaviour
{
    public AudioClip sonBagnole;

    void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(sonBagnole);
    }
}