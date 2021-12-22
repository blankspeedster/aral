using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Switch : MonoBehaviour
{

    public GameObject[] background;
    int index;
    public int count;

    // Start is called before the first frame update
    void Start()
    {
        count+= -1;
        index = 0;
        background[index].gameObject.SetActive(true);
    }




    public void NextButton()
    {
        index+=1;

        for(int i=0;i<background.Length;i++)
        {
            background[i].gameObject.SetActive(false);

                 if(index > count)
                    index = 0;
                
                if(index < 0)
                    index = count;
                    
            }
                background[index].gameObject.SetActive(true);
                Debug.Log(index);
    }

    public void BackButton()
    {
        index -=1;
         for(int i=0;i<background.Length;i++)
        {
            background[i].gameObject.SetActive(false);

                 if(index >count)
                    index = 0;
                
                if(index < 0)
                    index = count;
                    
            }
                background[index].gameObject.SetActive(true);
                Debug.Log(index);
    }

}
