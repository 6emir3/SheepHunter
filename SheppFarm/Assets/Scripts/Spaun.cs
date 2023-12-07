using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaun : MonoBehaviour
{
    [SerializeField]
    private GameObject smertobj;
    float smertRandX;
    Vector2 smertwhereToSpawn;
    [SerializeField]
    public static float smertspawnRate;
    [SerializeField]
    public static float smertnextSpawn;
    public float go;
    public float stop;
    public float speed;
    void Start()
    {
        smertspawnRate = speed;
        smertnextSpawn = speed;
    }

    void Update()
    {
        if (Time.time > smertnextSpawn)
        {
            smertnextSpawn = Time.time + smertspawnRate;
            smertRandX = Random.Range(go, stop);
            smertwhereToSpawn = new Vector2(smertRandX, transform.position.y);
            Instantiate(smertobj, smertwhereToSpawn, Quaternion.identity);
        }
    }
}
