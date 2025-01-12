using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject player;
    public GameObject segment;
    public int segment_count;
    public int segment_y;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Random.InitState(42);
        // 2 segments already in map when init
        segment_count = 2;
        // the init segments are all placed at y = -1
        segment_y = -1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GenerateSegment()
    {
        segment_y = segment_y + Random.Range(-1, 2);
        Instantiate(
            segment,
            new Vector3(0, segment_y, segment_count * 10),
            Quaternion.identity,
            transform
        );
        segment_count++;
    }
}
