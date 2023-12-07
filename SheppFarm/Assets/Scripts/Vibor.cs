using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Vibor : MonoBehaviour
{
    public GameObject[] KMBObject;
    public GameObject[] ProtivnicKMBObject;

    void Start()
    {

    }


    void Update()
    {

    }


    [SerializeField]
    Text text1;
    [SerializeField]
    Text text2;

    [SerializeField]
    GameObject del1;
    [SerializeField]
    GameObject del2;
    [SerializeField]
    GameObject del3;

    Reset res;



    int pob = 0;
    int por = 0;
    public void Smena(int index)
    {


        for (int i = 0; i < KMBObject.Length; i++)
        {
            if (i == index)
            {
                KMBObject[i].SetActive(true);
            }
            else
                KMBObject[i].SetActive(false);
        }

        int r = Random.Range(0, 3);
        for (int i = 0; i < ProtivnicKMBObject.Length; i++)
        {

            if (i == r)
            {
                ProtivnicKMBObject[i].SetActive(true);
            }
            else
                ProtivnicKMBObject[i].SetActive(false);
        }

        if (((index == 0) && (r == 1)) || ((index == 1) && (r == 2)) || ((index == 2) && (r == 0)))
        {

            pob += 1;
            text1.text = pob.ToString();
            if (pob == 3)
            {
                Destroy(del1);
                Destroy(del2);
                Destroy(del3);

            }


        }
        else if (((index == 1) && (r == 0)) || ((index == 2) && (r == 1)) || ((index == 0) && (r == 2)))
        {
            
            por += 1;
            text2.text = por.ToString();
            if (por == 3)
            {
                por = 0;
                pob = 0;
                text1.text = pob.ToString();
                text2.text = por.ToString();
            }
                



        }
    }


    public void SmenaRandom()
    {


    }
}
