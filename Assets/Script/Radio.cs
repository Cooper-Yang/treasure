using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Radio : MonoBehaviour
{
    public Transform tS;
    public Text text;
    
    void Update()
    {
        if(Vector3.Distance(tS.position,transform.position)<2){
            text.text = ("Charles! Go to the mountain");
        }
        else if(Vector3.Distance(tS.position,transform.position)>2&&Vector3.Distance(tS.position,transform.position)<3){
            text.text =("");
        }
    }
}
