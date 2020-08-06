using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class cancel_click : MonoBehaviour
{
    public Button yourButton;
    //public bool count=true;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void TaskOnClick()
    {
        click call = GameObject.Find("player").GetComponent<click>();
        call.count = false;
                      
        //count = true;
        Debug.Log("You have clicked the button!");
    }
}
