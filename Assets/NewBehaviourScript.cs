using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string animal = "양";
    int count = 0;

    void Start()
    {
        Debug.Log(animal + "세기 프로그램");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(++count + "마리");
    }
}

