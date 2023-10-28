
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectInstance : MonoBehaviour
{
    public GameObject apple;
    private float _time = 1f;
    private int spawnPosX = 4;
    private int spawnPosY = 4;
    private List<Vector2> occupiedPositionList;
    private Vector2 applePos;

    private void Start()
    {
        InvokeRepeating("AppleInstance", _time, _time);
    }

    private void Update()
    {
        if (occupiedPositionList.Count == 64)
        {
            CancelInvoke("AppleInstance");
        }
    }

    private void AppleInstance()
    {
        Instantiate(apple, RandomSpawnPos(applePos), apple.transform.rotation);
    }

    private Vector2 RandomSpawnPos(Vector2 applePos) 
    {
        int randomX = Random.Range(-spawnPosX, spawnPosX);
        int randomY = Random.Range(-spawnPosY, spawnPosY);

        Vector2 newVector;

        do
        {
          return newVector = new Vector2(randomX, randomY);

        } while (occupiedPositionList.Contains(newVector));
       
        if (!occupiedPositionList.Contains(newVector))
        {
            occupiedPositionList.Add(newVector);
        }
    }
}

