using UnityEngine;

public class Segment : MonoBehaviour
{
    public GameObject Floor;
    public GameObject Jump;
    public GameObject Boost;

    private Transform Map;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerateBlocks();
        Map = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    void GenerateBlocks()
    {
        for (int i = 0; i < 4; i++)
        {
            // include 0
            if (Random.Range(-4, 5) > 0)
            {
                Instantiate(Jump, transform.position + new Vector3(0, Random.Range(1, 6), Random.Range(1 + 2*i, 3 + 2*i)), Quaternion.identity, transform);
            }
            else
            {
                Instantiate(Boost, transform.position + new Vector3(0, Random.Range(1, 6), Random.Range(1 + 2 * i, 3 + 2 * i)), Quaternion.identity, transform);
            }
        }
        //GameObject newJump = Instantiate(Jump, transform.position + new Vector3(0, Random.Range(1, 6), Random.Range(0, 9)), Quaternion.identity, transform);
        //GameObject newJump2 = Instantiate(Jump, transform.position + new Vector3(0, Random.Range(1, 6), Random.Range(0, 9)), Quaternion.identity, transform);

        //GameObject newBoost = Instantiate(Boost, transform.position + new Vector3(0, Random.Range(1, 4), Random.Range(1, 8)), Quaternion.identity, transform);
        //GameObject newBoost2 = Instantiate(Boost, transform.position + new Vector3(0, Random.Range(1, 4), Random.Range(1, 8)), Quaternion.identity, transform);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Map.GetComponent<Map>().GenerateSegment();
        }
        
    }

}
