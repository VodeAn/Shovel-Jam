using System;
using Unity.Multiplayer.Center.Common;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public float anxietyMeter = 0;
    private float maxAnxiety = 100;
    
    void Start()
    {

    }

    // Update is called once per frame
    
    public void Anxiety()
    {
        if (anxietyMeter < maxAnxiety)
        {
            anxietyMeter += Time.deltaTime;
            Debug.Log("Anxiety increasing" + anxietyMeter);
        }
        else
        {
            anxietyMeter = 100;
            Debug.Log("Max Anxiety" + anxietyMeter);
        }
    }
}
