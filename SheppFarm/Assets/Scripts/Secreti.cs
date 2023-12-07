using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Secreti : MonoBehaviour
{
    string[] sekreti = { "���� �� ����� ����� ������������ � �����������. ��� ����� ��� ������� � ��������� �������, ������� � �������� ������� ������ �����������.\n���������� �� �������� ���������, ������ ����� �������� � ��������� � ����. � ��� ������� �������� ��� ������ ������ �� �����������.",
        "���� � ���� �� ����� �������� ����� �������, � ������� ������������� ������.\n� ���� �������� ������� ��������� ��������. ������, ������������� ������ ������ ���� ���� �� ������.",
        "�� ��� ��� ������ �� ������ ������� ������������� ������ ������� ������, �� ���������� �� �� �������� � ���������� �����.\n����� ������������ ���� � ������� ������, ������� ����� ������� �� 22-24 ���." };
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
