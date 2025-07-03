#if UNITY_EDITOR
    using UnityEditor;
#endif
    using UnityEngine;

using UnityEngine.SceneManagement;

public class BouttonHandler : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
    public void QuitApp()
    {
        #if UNITY_EDITOR
                EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }

}
