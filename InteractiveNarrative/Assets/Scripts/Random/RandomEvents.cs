using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class RandomEvents : MonoBehaviour
{
    public Flowchart flowchart;

     void Start()
    {
        PickRandomNumber(4);
    }
    

    private void PickRandomNumber(int maxInt)
    {
        flowchart.SetIntegerVariable("randomNum", Random.Range(1, maxInt + 1));
       
    }
    // Start is called before the first frame update
    
}
