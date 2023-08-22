using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Canvas : MonoBehaviour
{
    public Collider2D clickZone; // бокс-коллайдер с меткой триггер, в котором нужно регистрировать клики
    public GameObject panelToToggle; // панель, которую нужно включать и выключать
    private bool isPanelActive = false; // флаг, показывающий, активна ли в данный момент панель

    private void Start()
    {
        panelToToggle.SetActive(false); // изначально панель выключена
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // если нажата левая кнопка мыши
        {
            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // получаем координаты клика в мировых координатах

            if (clickZone.OverlapPoint(clickPosition)) // если клик был в зоне бокс-коллайдера
            {
                isPanelActive = !isPanelActive; // переключаем флаг активности панели

                if (isPanelActive)
                {
                    panelToToggle.SetActive(true); // включаем панель
                }
                else
                {
                    panelToToggle.SetActive(false); // выключаем панель
                }
            }
        }
    }
}
