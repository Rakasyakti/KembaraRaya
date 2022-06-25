using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    float val;
    bool srt;
    public Text Minutes;
    public Text Minutes2;
    public Text Seconds;
    public Text Seconds2;

    public GameObject endplate;
    // Start is called before the first frame update
    void Start()
    {
        val = 0;
        srt = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(srt){
            val += Time.deltaTime;
        }

        float minutes = Mathf.FloorToInt(val/60);
        Minutes.text = minutes.ToString("00");
        Minutes2.text = minutes.ToString("00");
        float seconds = Mathf.FloorToInt(val%60);
        Seconds.text = seconds.ToString("00");
        Seconds2.text = seconds.ToString("00");

        if(endplate.GetComponent<DockingCheck>().docked == true){
            srt = false;
        }
    }
}
