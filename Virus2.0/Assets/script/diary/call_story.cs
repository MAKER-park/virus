using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class call_story : MonoBehaviour
{
    public Text ScriptTxt;
    int Day,hungry,DogHungry;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScriptTxt.text = "";
        hungry = GameObject.Find("player").GetComponent<status>().hungry;
        Day = GameObject.Find("player").GetComponent<status>().day;
        if (hungry == 0) ScriptTxt.text = "";
        else if (hungry == 1) ScriptTxt.text = "나는 배가 고프다";
        else if (hungry == 2) ScriptTxt.text = "나는 배가 죽을만큼 고프다";
        else if (hungry == 3) ScriptTxt.text = "나는 이제 곧 죽을 것 같다. 어떻게 해야할까..";
        else if (hungry == 4) ScriptTxt.text = "DEAD ENDING...........";

        if(hungry != 4)
        {
            DogHungry = GameObject.Find("player").GetComponent<status>().DogHungry;
            if (DogHungry == 0) ScriptTxt.text += "\n 우리 강아지는 내 곁을 졸졸 따라오며 기쁜 내색을 보인다.";
            else if (DogHungry == 1) ScriptTxt.text += "\n 강아지가 피곤한 내색을 보이기는 하지만 아직까지는 괜찮아 보인다.";
            else if (DogHungry == 2) ScriptTxt.text += "\n 나를 보고 신경질이 난 듯 사납게 짓고...\n" +
                    "비어있는 식량캔을 물끄러미 보거나 빈 깡통을 핧는다..";
            else if (DogHungry == 3) ScriptTxt.text += "\n 강아지가 몸을 둥글게 말고 있다.. \n" +
                      "흔들어보아도 움직이지 않는다... ";
            Day = GameObject.Find("player").GetComponent<status>().day;
            if (Day == 3) ScriptTxt.text += "\n\n 조금 이상하다.\n" +
                    "어제까지만 해도 잘 나오던 물이 전혀 나오지 않는다.\n " +
                    "어딘가 걸린 것처럼 보이는데 집 안에서 수리할 수 있을까?";
            else if (Day == 6) ScriptTxt.text += "\n\n 정오쯤 소파에 삐딱하게 앉아서 무엇이라도 나오지 않을까라는 희망을 품은 채로 TV의 채널을 초조하게 돌리고 있었다.\n" +
                       "채널을 돌리기 시작한지 꽤나 시간이 많이 지난 상태에서 갑자기 긴급재난방송이 온 채널에서 방영되기 시작한다.\n" +
                       "순간 당황했지만, 방송에 집중을 해야만 하는 순간이었다.\n" +
                       "\"금일 8월 6일부로 정부는 이 좀비를 만들어낸다는 이 바이러스에 대해 전쟁을 선포합니다.\"\n" +
                       "“........살아남으신 국민분들께서는............내일깢...........”\n" +
                       "방송도중에 잡음이 섞이더니 아예 방송이 끊기고 말았다.\n" +
                       "지금 이 기회를 놓쳐버린다면 앞으로 미래가 없을 것임은 자명했다.\n" +
                       "한 시라도 빨리 기기를 고쳐서 방송을 들어야만 한다!";
        }
        else
        {
            ScriptTxt.text += "\n\n";
        }

        
    }
}
