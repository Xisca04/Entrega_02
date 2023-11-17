
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

    private void Start()
    {
        occupiedPositionList = new List<Vector2>();
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
        Instantiate(apple, RandomSpawnPos(), apple.transform.rotation);
    }

    private Vector2 RandomSpawnPos() 
    {
        Vector2 newVector;

        do
        {
            int randomX = Random.Range(-spawnPosX, spawnPosX);
            int randomY = Random.Range(-spawnPosY, spawnPosY);
            newVector = new Vector2(randomX, randomY);

        } while (occupiedPositionList.Contains(newVector));
       
        if (!occupiedPositionList.Contains(newVector))
        {
            occupiedPositionList.Add(newVector);
        }

        return newVector;
    }

    /*
     �Buen trabajo!

     Veo que has optado por usar una imagen completa de un tablero. La has configurado correctamente. Bien hecho

     Cuidado que te queda una manzana por ah� suelta en la escena que no pinta nada

     Buena elecci�n la de usar InvokeRepeating

     Cuidado con usar Magic numbers

     Podr�as hacer la comprobaci�n del Update en otro sitio, pues basta comprobar antes de instanciar y no constantemente

     F�jate que el if despu�s del while no es necesario, pues si sales del while es porque la condici�n del while es falsa

    */

}

