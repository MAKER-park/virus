using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class status : MonoBehaviour
{



    public int hungry;
    public int food;
    public int HP;
    public int tool;
    public bool gun;
    public bool knife;
    public int day;
    public int DogHungry;

    // Start is called before the first frame update
    void Start()
    {
        string line;
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        day = 1;
        food = 3;
        tool = 3;
        knife = false;
        gun = false;
        HP = 3;
        hungry = 1;
        DogHungry = 0;
        //string strColumn;

        //TextAsset data = Resources.Load("Assets/MyItemText.txt", typeof(TextAsset)) as TextAsset;
        StreamReader sr = new StreamReader("Assets/MyItemText.txt");
        line = sr.ReadLine();
        //Debug.Log(line);
        // Read and display lines from the file until the end of 
        // the file is reached.

        //if (sr.ReadLine())
        for (int i = 0; i < line.Length; i++)
        {
            //Debug.Log(line[i]);
            if (line[i] == '}')
            {
                count1++;
                //Debug.Log("find!");
                if (line[i - 4] == 't')
                {
                    if (count2 == 0)
                    {
                        count2 = count1;
                    }
                    if (count2 != count1)
                    {
                        count3 = count1;
                    }
                    //Debug.Log("find!");

                }
            }
        }
        Debug.Log(count2);
        Debug.Log(count3);

        switch (count2)
        {
            case 1:
                food++;
                break;

            case 2:
                tool++;
                break;

            case 3:
                knife = true;
                break;

            case 4:
                gun = true;
                break;
        }

        switch (count3)
        {
            case 1:
                food++;
                break;

            case 2:
                tool++;
                break;

            case 3:
                knife = true;
                break;

            case 4:
                gun = true;
                break;
        }



    }

    // Update is called once per frame
    void Update()
    {



    }
}