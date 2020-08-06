using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class call_day : MonoBehaviour
{
    int day;
    public Text ScriptTxt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        day = GameObject.Find("player").GetComponent<status>().day;
        ScriptTxt.text = day + "일째..";

        
    }
}
