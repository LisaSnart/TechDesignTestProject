using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest_open_anim : MonoBehaviour
{
    public Animator animator;
    public bool isActivated = false;
    public AudioSource clickSound; // Звук открытия

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        if (isActivated)
        {
            isActivated = false;
            animator.SetBool("Activate", false); // Деактивируем анимацию с помощью булевого параметра "Activate"
        }
        else
        {
            isActivated = true;
            animator.SetBool("Activate", true); // Активируем анимацию с помощью булевого параметра "Activate"
        }

        if (clickSound != null)
        {
            clickSound.Play(); // Воспроизводим звук открытия
        }
    }
}
