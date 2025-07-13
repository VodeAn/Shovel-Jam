using UnityEngine;

public class GameManager : MonoBehaviour
{
   
    
    public void Anxiety(float anxietyMeter)
    {
        if (anxietyMeter < 100)
        {
            anxietyMeter += Time.deltaTime;
            Debug.Log("Increasing");
        }
        else
        {
            anxietyMeter = 100;
            Debug.Log("Max");
        }
    }
}
