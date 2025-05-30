using UnityEngine;
using UnityEngine.UI;

public class HPScrollbar : MonoBehaviour
{
    public Scrollbar scrollbar;

    private float accTime;
    private float time = 5.0f;

    void Start()
    {
        scrollbar.value = 1;
    }

    void Update()
    {
        if (scrollbar.value <= 0)
        {
            return;
        }

        accTime += Time.deltaTime;

        scrollbar.value = 1 - accTime / time;
    }
}
