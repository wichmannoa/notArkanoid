using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour {

    public void loadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
}
