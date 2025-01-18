using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject player;
    public GameObject segment;
    public Queue<GameObject> exist_segments;
    public int max_map_length = 10;
    public int segment_count;
    public int segment_y;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Random.InitState(42);
        exist_segments = new Queue<GameObject>();
        segment_count = 0;
        // the init segments are all placed at y = -1
        segment_y = -1;
        for (int i = 0; i < max_map_length - 2; i ++)
        {
            GenerateSegment();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GenerateSegment()
    {
        segment_y = segment_y + Random.Range(-1, 2);
        GameObject new_segment = Instantiate(
            segment,
            new Vector3(0, segment_y, segment_count * 10),
            Quaternion.identity,
            transform
        );
        if (exist_segments.Count >= max_map_length)
        {
            Destroy(exist_segments.Dequeue());
        }
        exist_segments.Enqueue(new_segment);
        segment_count++;
    }
}
