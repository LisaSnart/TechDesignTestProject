using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Canvas : MonoBehaviour
{
    public Collider2D clickZone; // ����-��������� � ������ �������, � ������� ����� �������������� �����
    public GameObject panelToToggle; // ������, ������� ����� �������� � ���������
    private bool isPanelActive = false; // ����, ������������, ������� �� � ������ ������ ������

    private void Start()
    {
        panelToToggle.SetActive(false); // ���������� ������ ���������
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ���� ������ ����� ������ ����
        {
            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // �������� ���������� ����� � ������� �����������

            if (clickZone.OverlapPoint(clickPosition)) // ���� ���� ��� � ���� ����-����������
            {
                isPanelActive = !isPanelActive; // ����������� ���� ���������� ������

                if (isPanelActive)
                {
                    panelToToggle.SetActive(true); // �������� ������
                }
                else
                {
                    panelToToggle.SetActive(false); // ��������� ������
                }
            }
        }
    }
}
