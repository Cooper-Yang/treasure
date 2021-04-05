using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rocket : MonoBehaviour
{
    public Transform tS;
    public Text text;
    
    void Update()
    {
        if(Vector3.Distance(tS.position,transform.position)<10){
            text.text = ("Houston? I found the rocket!");
        }
        else if(Vector3.Distance(tS.position,transform.position)>10&&Vector3.Distance(tS.position,transform.position)<11){
            text.text =("");
        }
    }
}
