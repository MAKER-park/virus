using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class sleep : MonoBehaviour
{
    public Button yourButton;
    public Image night;
    private Color color;
    public GameObject panel;


    private WaitForSeconds waitTime = new WaitForSeconds(0.01f);
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

        status call1 = GameObject.Find("player").GetComponent<status>();
        call1.day++;
        call1.hungry++;
        call1.DogHungry++;
        if (panel != null)
        {
            Animator animator = panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("open");

                animator.SetBool("open", !isOpen);
            }
        }

        //Debug.Log("You have clicked the button!");
    }

    



}
