using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    [SerializeField]
    private Image gauge;

    private float accTime;

    private float time;

    void Start()
    {
        gauge.fillAmount = 1;
        time = 5.0f;
    }

    void Update()
    {
        if (gauge.fillAmount <= 0)
        {
            return;
        }

        //accTime += Time.deltaTime;
        //gauge.fillAmount = 1 - accTime / time;

        if (Input.GetKeyDown(KeyCode.A))
        {
            gauge.fillAmount -= 0.1f;
        }
    }
}
