using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Test");
    }

    public void Quit()
    {
        Application.Quit();
    }

}

