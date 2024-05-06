using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryLap : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject cerdo01;
    [SerializeField] GameObject cerdo02;
    [SerializeField] GameObject castle1;
    [SerializeField] GameObject castle2;

    private void Update()
    {
        if (cerdo01 == null)
        {
            castle1.SetActive(false);
            castle2.SetActive(true);
        }
        if (cerdo02 == null)
        {
            castle2.SetActive(false);
            mainMenu.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Castle"))
        {

            print("Hola Mundo");
            //SceneManager.LoadScene(0);
            mainMenu.SetActive(true);
            
        }
    }
}
