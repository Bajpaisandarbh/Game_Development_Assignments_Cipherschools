using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Statements : MonoBehaviour
{
    public int age;

    // Start is called before the first frame update
    void Start()
    {
        if(age > 18){
            Debug.Log("You can vote");// code to be executed if condition is true
        }
        else{
            Debug.Log("You can't vote");// code to be executed if condition is false
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
