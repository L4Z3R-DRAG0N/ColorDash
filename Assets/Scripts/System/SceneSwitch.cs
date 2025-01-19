using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void trigger(string scene_name)
    {
        SceneManager.LoadSceneAsync(scene_name);
    }
}
