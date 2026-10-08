using UnityEngine;

public class BrakeTrigger : MonoBehaviour
{
    public AudioClip sonBagnole;

    void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(sonBagnole);
    }
}