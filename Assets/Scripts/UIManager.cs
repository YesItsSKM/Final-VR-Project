using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI buttonText;

    int pressCount = 0;

    public void MainButtonPressed()
    {
        pressCount++;
        
        buttonText.text = pressCount.ToString();
    }
}
