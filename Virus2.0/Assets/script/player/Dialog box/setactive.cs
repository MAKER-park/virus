using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setactive : MonoBehaviour
{
    public GameObject activity;
    public GameObject activity1;
    public GameObject activity2;
    public GameObject activity3;
    public GameObject activity4;
    public bool count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count = GameObject.Find("player").GetComponent<click>().count;
        if (count == false)
        {

            activity.SetActive(false);
            activity1.SetActive(false);
            activity2.SetActive(false);
            activity3.SetActive(false);
            activity4.SetActive(false);

        }
        if (count == true)
        {

            activity.SetActive(true);
            activity1.SetActive(true);
            activity2.SetActive(true);
            activity3.SetActive(true);
            activity4.SetActive(true);

        }

    }
}
