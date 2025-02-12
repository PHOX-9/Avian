using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenechange : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadSceneAsync(1);
    }

    public void quitGame(){
        Application.Quit();
    }
}
