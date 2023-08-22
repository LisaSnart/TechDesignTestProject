using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderScript : MonoBehaviour
{
    public void LoadSceneNumberOne()
    {
        SceneManager.LoadScene(1); // загружаем сцену с номером 1
    }
}
