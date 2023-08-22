using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat_fall_anim : MonoBehaviour
{
    public Animator animator;
    public bool isActivated = false;
    public AudioSource clickSound; // «вук м€у

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        if (isActivated)
        {
            isActivated = false;
            animator.SetBool("Activate", false); // ƒеактивируем анимацию с помощью булевого параметра "Activate"
        }
        else
        {
            isActivated = true;
            animator.SetBool("Activate", true); // јктивируем анимацию с помощью булевого параметра "Activate"
        }

        if (clickSound != null)
        {
            clickSound.Play(); // ¬оспроизводим звук м€у
        }
    }
}
