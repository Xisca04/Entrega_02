
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
    private Vector2 newPosition;

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
        Instantiate(apple, RandomSpawnPos(applePos, newPosition), apple.transform.rotation);
    }

    private Vector2 RandomSpawnPos(Vector2 applePos, Vector2 newPosition) 
    {
        int randomX = Random.Range(-spawnPosX, spawnPosX);
        int randomY = Random.Range(-spawnPosY, spawnPosY);
        return applePos = new Vector2(randomX, randomY);
        occupiedPositionList.Add(applePos);

        if (occupiedPositionList.Count = true)
        {
            return newPosition = new Vector2(randomX,randomY);
            occupiedPositionList.Add(newPosition);
        }
    }

    //bucle do while encontrar vector que no está en lista --> lo guardas en la lista
/*
    do
    {

    }
    while()
*/
}
