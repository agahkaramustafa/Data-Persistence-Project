using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] TMP_InputField nameInputField;

    void Awake() 
    {

    }

    public void StartGame()
    {
        GameManager.Instance.playerNameStart = nameInputField.text;
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        if (UnityEditor.EditorApplication.isPlaying)
        {
            UnityEditor.EditorApplication.ExitPlaymode();
        }
        else
        {
            Application.Quit();
        }
    }

}
