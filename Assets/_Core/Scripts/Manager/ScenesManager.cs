using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    [SerializeField] private string[] _sceneLoadInStart = new string[0];

    private void Start()
    {
        if (_sceneLoadInStart.Length > 0)
        {
            foreach (string name in _sceneLoadInStart)
            {
                SceneManager.LoadScene(name, LoadSceneMode.Additive);
            }
        }
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void Quit()
    {
        PlayerPrefs.Save();
        Application.Quit();
    }
}
