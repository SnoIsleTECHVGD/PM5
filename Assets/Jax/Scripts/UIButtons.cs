using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Pause");
    }

    public void Quit()
    {
        Application.Quit();
    }

}

