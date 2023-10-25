using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectInstance : MonoBehaviour
{
    public GameObject apple;
   
    private float _time = 1f;
   
    private int spawnPosX = 2;
    private int spawnPosY = 2;

    private void Start()
    {
        InvokeRepeating("AppleInstance", _time, _time);

        // CancelInvoke("AppleInstance"); para parar las instancias
    }

    private void AppleInstance()
    {
        Instantiate(apple, RandomSpawnPos(), apple.transform.rotation);
    }

    private Vector2 RandomSpawnPos() 
    {
        int randomX = Random.Range(-spawnPosX, spawnPosX);
        int randomY = Random.Range(-spawnPosY, spawnPosY);
        return new Vector2(randomX, randomY);

        /*
        if (applePosition = ocuppedPosition)
        {
            return new Vector2(randomX, randomY);
        }
        */
    }
}
