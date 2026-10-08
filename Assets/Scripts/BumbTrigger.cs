using UnityEngine;

public class BumbTrigger : MonoBehaviour
{
    public AudioClip sonBagnole;

    void Update()
    {
        GetComponent<AudioSource>().PlayOneShot(sonBagnole);
    }
}