using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;


public class test_count : MonoBehaviour
{
    public int tool;
    public int food;
    
   
    // Start is called before the first frame update
    void Start()
    {
        tool = GameObject.Find("player").GetComponent<tool_count>().tool;
        food = GameObject.Find("player").GetComponent<food_count>().food;
        Debug.Log("tool : " + tool);
        Debug.Log("food : " + food);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
