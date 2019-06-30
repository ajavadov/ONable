using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.UI;

public class sControl : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject subWheel;
    
    public Text sName, subName;
    public Manager manager;
    public static int sNum;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadSubArray()
    {
        subWheel.SetActive(true);
        sName.text = gameObject.GetComponentInChildren<Text>().text;
        
        for (int i = 1; i <= 8; i++)
        {
            GameObject.Find("sub_" + i).GetComponentInChildren<Text>().text = manager.getSubString((int.Parse(gameObject.name)-1)*8+i);
           if(manager.getSubString((int.Parse(gameObject.name)-1)*8+i).Equals(""))
           {
                GameObject.Find("sub_"+i).GetComponent<Image>().color = new Color(38,38,38);
                Debug.Log("OK");
           }
        }

        sNum = int.Parse(gameObject.name);

    }
}
