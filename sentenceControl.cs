using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;

public class sentenceControl : MonoBehaviour
{
    public GameObject addPanel;
    public InputField field;
    public int senNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //
    
    public void getNumOfSentence()
    {
        senNum = int.Parse(transform.parent.gameObject.name.Substring(4, 1));
    }
    
    public void addSentence()
    {
        string typed = field.text;
        Manager.sentArr[((sControl.sNum - 1) * 80 + (subControl.subNum-1)*10+senNum)] = typed;

        //for (int i = 0; i < 640; i++)
        //{
        //    Debug.Log(Manager.sentArr[i]);
        //}
       // addPanel.SetActive(false);
       Debug.Log(senNum);
    }

    public void showInputPanel()
    {
        addPanel.SetActive(true);
    }
}
