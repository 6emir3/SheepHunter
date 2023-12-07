using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gotonextlevel : MonoBehaviour
{
    public int ras;
    public static int Count;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Count+=1;
        
        if ((collision.CompareTag("Player"))&&(Count==3))
        {
            Count = 0;
            if (PlayerPrefs.GetInt("levels")< ras - 1)
            { 
                PlayerPrefs.SetInt("levels", ras - 1);
                PlayerPrefs.SetInt("secrets", PlayerPrefs.GetInt("secrets")+1);
                PlayerPrefs.SetInt("sheepCount", PlayerPrefs.GetInt("sheepCount")+3);
            }
            
            SceneManager.LoadScene(1);
        }
        Destroy(gameObject);
    }

    
}


