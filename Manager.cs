using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public AudioSource _source; 
    AudioClip sentSound;
    public string[] subArr;
    public static string[] sentArr;
    public GameObject subWheel, sentences;
    
    
    // Start is called before the first frame update
    void Start()
    {
        subArr = new string[65];
        sentArr = new string[641];
        
        readFromTxt("sentences", sentArr);
        readFromTxt("subarrays", subArr);
        
        
        
    }

    // Update is called once per frame
    void Update()
    {    
        
    }
    

    void readFromTxt(string fileName, string[] arr)
    {
        StreamReader reader = new StreamReader("./Assets/"+fileName+".txt");
        String itemStrings = reader.ReadToEnd();
        char[] delimiter = {'@'};

        while (itemStrings != null) 
        {
            string[] fields = itemStrings.Split(delimiter);
            
           // Debug.Log(fields.Length);
            for (int i = 0; i < fields.Length; i++)
            {
               arr[i] = fields[i];
            }
            
            itemStrings = reader.ReadLine();
        }
        
    }
    

    public void playSentenceAudio()
    {
        for (int i = 0; i < sentArr.Length; i++)
        {
            if(gameObject.GetComponentInChildren<Text>().text.Equals(sentArr[i]))
            {
                sentSound = Resources.Load<AudioClip>("sounds/"+(i-1));
                _source.clip = sentSound;
                _source.Play();
                Debug.Log("SUCCEFULL");
            }
        }
        
        
        gameObject.GetComponent<AudioSource>().clip = sentSound;
    }

    public string getSubString(int index)
    {
        string sub = subArr[index];
        return sub;
    }
    
    public string getSentence(int index)
    {
        string sent = sentArr[index];
        return sent;
    }

    

    public void backToMenu()
    {
        subWheel.SetActive(false);
        sentences.SetActive(false);
    }
}
