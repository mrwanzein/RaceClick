using UnityEngine;

public class OnQuitClick : MonoBehaviour {

    public void Quit()
    {
        // platform specific compilation (it's code running if a specific environment is true )
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
