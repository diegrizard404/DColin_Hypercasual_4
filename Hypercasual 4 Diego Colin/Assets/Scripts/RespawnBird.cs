using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBird : MonoBehaviour
{

    public static RespawnBird instance;

    [SerializeField] GameObject bird;




    private void Awake()
    {
        if ( instance == null)
        {
            instance = this; 
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void Spawnbird()
    {
        GameObject temp = Instantiate(bird);
    }
}
