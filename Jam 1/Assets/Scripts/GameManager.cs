using UnityEngine;

public class GameManager : MonoBehaviour
{
   
    
    public void Anxiety(float anxietyMeter)
    {
        if (anxietyMeter < 100)
        {
            anxietyMeter += Time.deltaTime;
        }
        else
        {
            anxietyMeter = 100;
        }
    }
}
