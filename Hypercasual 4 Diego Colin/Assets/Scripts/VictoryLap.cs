using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryLap : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;

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
