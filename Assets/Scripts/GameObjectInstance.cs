
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectInstance : MonoBehaviour
{
    public GameObject apple;
   
    private float _time = 1f;
   
    private int spawnPosX = 4;
    private int spawnPosY = 4;

    private Vector2 applePos;
    //private Vector2 ocuppiedPos;

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
        bool isOcuppied = AppleInstance.apple.TRposition;
        
        if (isOcuppied)
        {
            return new Vector2(randomX, randomY);
        }
        */
    }

}
