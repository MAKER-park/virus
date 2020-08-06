using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tool_count : MonoBehaviour
{
    public int tool;
    public int num_tool;

    public Image[] tools;
    public Sprite Fulltool;
    public Sprite emptytool;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tool = GameObject.Find("player").GetComponent<status>().tool;

        for (int i = 0; i < tools.Length; i++)
        {
            if (i < tool)
            {
                tools[i].sprite = Fulltool;
            }
            else
            {
                tools[i].sprite = emptytool;
            }

            if (i < num_tool)
            {
                tools[i].enabled = true;
            }
            else
            {
                tools[i].enabled = false;
            }

        }
        

    }
}
