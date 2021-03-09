using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderWithParameter : MonoBehaviour
{
    public void LoadNextSceneWithParamString(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void LoadNextSceneWithBuildIndex(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }
}
