using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Secreti : MonoBehaviour
{
    string[] sekreti = { "Овцы не могут долго существовать в одиночестве. Без стада они впадают в состояние тревоги, которое с течением времени только усиливается.\nОказавшись на открытой местности, овечье стадо пугается и сбивается в кучу. А вот наличие изгороди или забора вокруг их успокаивает.",
        "Овцы — одни из очень немногих живых существ, у которых прямоугольные зрачки.\nУ этих созданий нередко рождаются близнецы. Кстати, новорожденные ягнята узнают свою мать по голосу.",
        "До сих пор учёным не удаётся создать синтетический аналог овечьей шерсти, не уступающий ей по качеству и сохранению тепла.\nСамые долгоживущие овцы — снежные бараны, которые могут прожить до 22-24 лет." };
    public Text text;
    void Start()
    {
        int secretUnlock = PlayerPrefs.GetInt("secrets", 0);
        for(int i = 0; i < secretUnlock; i++)
        {
            text.text += sekreti[secretUnlock] + "\n";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
