using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class subControl : MonoBehaviour
{

    public GameObject sentPanel;
    public Text subName;
    public Manager manager;
    public static int subNum;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loadSentArray()
    {
        sentPanel.SetActive(true);
        subName.text = gameObject.GetComponentInChildren<Text>().text;

        for (int i = 0; i < 10; i++)
        {
            GameObject.Find("sen_" + i).GetComponentInChildren<Text>().text =
                manager.getSentence(((sControl.sNum-1)*80 + (int.Parse(gameObject.name.Substring(4, 1))-1)*10 + i+1));
        }
        
        subNum = int.Parse(gameObject.name.Substring(4, 1));
    }
}