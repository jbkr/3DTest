using TMPro;
using UnityEngine;

public class TimeAttack : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI roundOver;

    private TextMeshProUGUI m_TextMeshPro;

    private float accTime;

    private float roundTime = 3.0f;

    private float remainingTime;

    void Start()
    {
        roundOver.enabled = false;

        m_TextMeshPro = GetComponent<TextMeshProUGUI>();
        m_TextMeshPro.text = roundTime.ToString();
        remainingTime = roundTime;
    }

    void Update()
    {
        if (remainingTime <= 0)
        {
            roundOver.enabled = true;
            return;
        }

        accTime += Time.deltaTime;

        if (accTime >= 1.0f)
        {
            remainingTime = roundTime--;
            m_TextMeshPro.text = remainingTime.ToString();
            accTime = 0.0f;
        }
    }
}
