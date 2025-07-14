using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] private Image anxietyBar;
    private float anxietyMeter = 0;
    public void Anxiety()
    {
        if (anxietyMeter < 100)
        {
            anxietyMeter += Time.deltaTime;
            Debug.Log("Increasing");
            anxietyBar.fillAmount = anxietyMeter / 100;

        }
        else
        {
            anxietyMeter = 100;
            Debug.Log("Max");

        }
    }
}
