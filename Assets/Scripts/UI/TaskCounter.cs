using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskCounter : MonoBehaviour
{
    [SerializeField]
    Text taskRemain;
    [SerializeField]
    GameObject destroyTrigger;
    [SerializeField]
    GameObject destroyTrigger2;

    public static int taskCount;
    private int taskNumber;
    // Start is called before the first frame update
    void Start()
    {
        taskNumber += taskCount;
        Debug.Log(taskNumber);
        switch  (taskCount)
        {case 1:
          
            taskRemain.text = taskNumber + " /4";
            
        break;
        
       case 2:
           
            taskRemain.text = taskNumber + " /4";
            //Destroy(destroyTrigger2);
        break;

        }

        
    }
}
