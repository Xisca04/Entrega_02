
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
        if(occupiedPositionList.Count == 0)
        {
            InvokeRepeating("AppleInstance", _time, _time);
        }
        else if(occupiedPositionList.Count == 64)
        {
            CancelInvoke("AppleInstance");
        }
    }

    private void AppleInstance()
    {
        Instantiate(apple, RandomSpawnPos(), apple.transform.rotation);
    }

    private Vector2 RandomSpawnPos(Vector2 pos) 
    {
        int randomX = Random.Range(-spawnPosX, spawnPosX);
        int randomY = Random.Range(-spawnPosY, spawnPosY);
        return new Vector2(randomX, randomY);
        
        if (occupiedPositionList.Count == false)
        {
            return new Vector2(randomX, randomY);
            occupiedPositionList.Add(new Vector2(randomX, randomY));
        }
    }
}
