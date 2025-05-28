using UnityEngine;
using UnityEngine.UI;

public class StageUI : MonoBehaviour
{
    [SerializeField]
    private CustomButton[] customButtons;

    private int currentIndex;

    void Start()
    {
        for (int i = 0; i < customButtons.Length; i++)
        {
            customButtons[i].setIndex(i);
            customButtons[i].onClick.AddListener(OnCustomButtonClicked);
        }
    }

    public void setCurrentIndex(int index)
    {
        currentIndex = index;
    }

    private void OnCustomButtonClicked()
    {
        for (int i = 0; i < customButtons.Length; i++)
        {
            customButtons[i].targetGraphic.color = Color.blue;
        }
        customButtons[currentIndex].targetGraphic.color = Color.red;
    }
}
