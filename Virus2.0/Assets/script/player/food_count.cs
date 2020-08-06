using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class food_count : MonoBehaviour
{
    public int food;
    public int num_food;

    public Image[] foods;
    public Sprite FullFood;
    public Sprite emptyFood;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        food = GameObject.Find("player").GetComponent<status>().food;

        for (int i =0; i < foods.Length ; i++)
        {
            if (i < food)
            {
                foods[i].sprite = FullFood;
            }
            else
            {
                foods[i].sprite = emptyFood;
            }

            if (i< num_food)
            {
                foods[i].enabled = true;
            }
            else
            {
                foods[i].enabled = false;
            }

        }
        
    }
}
