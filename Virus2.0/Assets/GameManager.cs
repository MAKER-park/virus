using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Item
{
    public Item(string _Type,string _Name,string _Explain,string _Number,bool _isUsing)
    {
        Type = _Type;Name = _Name;Explain = _Explain;Number = _Number;isUsing = _isUsing;
    }
    public string Type, Name, Explain, Number;
    public bool isUsing;
}
public class GameManager : MonoBehaviour
{
    public TextAsset ItemDatabase;
    public List<Item> AllItemList,MyItemList,CurItemList;
    public string curType="Item";
    public Image[] ItemImage;
    public GameObject[] Slot,UsingImage;
    public GameObject ExplainPanel;
    IEnumerator PointerCoroutine;
    void Start()
    {
        //전체 아이템 리스트 불러오기
        string[] line = ItemDatabase.text.Substring(0, ItemDatabase.text.Length - 1).Split('\n');
        for(int i = 0; i < line.Length; i++)
        {
            string[] row = line[i].Split('\t');

            AllItemList.Add(new Item(row[0], row[1], row[2], row[3], row[4] == "TRUE"));
        }
        Load();
    }

    public void Next()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void SlotClick(int slotNum)
    {
        Item CurItem = CurItemList[slotNum];
        Item UsingItem = CurItemList.Find(x => x.isUsing == true);

        if (curType == "Item")
        {
            CurItem.isUsing = !CurItem.isUsing;
        }
        Save();
    }
    public void TabClick(string tabName)
    {
        curType = tabName;
        CurItemList = MyItemList.FindAll(x => x.Type == tabName);

        //슬롯 텍스트 보이기
        for(int i = 0; i < Slot.Length; i++)
        {
            Slot[i].SetActive(i < CurItemList.Count);
            Slot[i].GetComponentInChildren<Text>().text = i < CurItemList.Count ? CurItemList[i].Name :"";

            bool isExist = i < CurItemList.Count;
            if (isExist)
            {
                UsingImage[i].SetActive(CurItemList[i].isUsing);
            }
        }
    }
    public void PointerEnter(int slotNum)
    {
        PointerCoroutine = PointerEnterDelay(slotNum);
        StartCoroutine(PointerCoroutine);

        ExplainPanel.GetComponentInChildren<Text>().text = CurItemList[slotNum].Name;
        ExplainPanel.transform.GetChild(1).GetComponent<Text>().text = CurItemList[slotNum].Explain;

    }

    IEnumerator PointerEnterDelay(int slotNum)
    {
        yield return new WaitForSeconds(0);
        ExplainPanel.SetActive(true);
    }
    public void PointerExit(int slotNum)
    {
        StopCoroutine(PointerCoroutine);
        ExplainPanel.SetActive(false);
    }
    void Save()
    {
        string jdata = JsonConvert.SerializeObject(MyItemList);
        File.WriteAllText(Application.dataPath + "/MyItemText.txt", jdata);

        TabClick(curType);
    }

    void Load()
    {
        string jdata = File.ReadAllText(Application.dataPath + "/MyItemText.txt");
        MyItemList = JsonConvert.DeserializeObject<List<Item>>(jdata);

        TabClick(curType);
    }
}
