using TMPro;
using UnityEngine;

public class SementCounter : MonoBehaviour
{
    public Map map;
    public TMP_Text counter_display;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        counter_display = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        counter_display.text = (map.segment_count-9).ToString();
    }
}
