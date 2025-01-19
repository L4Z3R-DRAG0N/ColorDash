using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Map map;
    public PlayerController player;
    public Timer timer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadSceneAsync("StartMenu");
        }
    }

    public void Reset()
    {
        map.Init();
        player.Init();
        timer.Init();
    }
}
