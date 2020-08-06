using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("ItemScene");
    }

    public void NextButton()
    {
        SceneManager.LoadScene("MainScene");
    }
}
