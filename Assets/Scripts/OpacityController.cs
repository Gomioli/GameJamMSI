using UnityEngine;
using UnityEngine.UI;

public class OpacityController : MonoBehaviour
{
    [SerializeField] private Image background;
    [SerializeField] private float opacity = 0.5f;
    
    void Start()
    {
        Color c = background.color;
        c.a = opacity;
        background.color = c;
    }

    
}
