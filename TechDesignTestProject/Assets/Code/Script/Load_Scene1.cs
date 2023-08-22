using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Scene1 : MonoBehaviour
{
    public void LoadSceneNumberZero()
    {
        SceneManager.LoadScene(0); // загружаем сцену с номером 0
    }
}
