using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController cC;
    
    // Start is called before the first frame update
    void Start()
    {
        cC = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            cC.Move( transform.forward *0.05f);
        }
        if(Input.GetKey(KeyCode.S)){
            cC.Move( -transform.forward *0.05f);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.Rotate(0,-1f,0);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Rotate(0,1f,0);
        }
        cC.Move(new Vector3(0,-1,0));
    }
}
