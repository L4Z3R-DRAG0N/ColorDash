using UnityEngine;

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
    }

    public void Reset()
    {
        map.Init();
        player.Init();
        timer.Init();
    }
}
