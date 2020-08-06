using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setactive_gun : MonoBehaviour
{
    public GameObject activity;
    public bool count;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        count = GameObject.Find("player").GetComponent<status>().gun;
        if (count == false)
        {

            activity.SetActive(false);

        }
        if (count == true)
        {

            activity.SetActive(true);

        }

    }
}
