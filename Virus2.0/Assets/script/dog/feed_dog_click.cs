using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class feed_dog_click : MonoBehaviour
{
    public bool count = false;
    public Button yourButton;
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
        count = true;
        status call = GameObject.Find("player").GetComponent<status>();
        call.food--;
        call.DogHungry = 0;

        dog call1 = GameObject.Find("player").GetComponent<dog>();
        call1.count = false;

                //Debug.Log("You have clicked the button!");
    }
}
