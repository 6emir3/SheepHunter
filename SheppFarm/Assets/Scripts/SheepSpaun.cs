using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepSpaun : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject Sheep;
    void Start()
    {
        int sheepCount = PlayerPrefs.GetInt("sheepCount");
        for (int i = 0; i < sheepCount; i++)
        {
            
            float RandX = Random.Range(-7f, 4f);
            Vector2 whereToSpawn = new Vector2(RandX, SpawnPos.position.y);
            Instantiate(Sheep, whereToSpawn, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
