using UnityEngine;
using UnityEngine.UI;

public class HPSlider : MonoBehaviour
{
    private Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = 1;
    }

    void Update()
    {

    }
}
