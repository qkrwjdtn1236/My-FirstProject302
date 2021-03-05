using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorScript : MonoBehaviour
{
    Vector3 moveVelocity = new Vector3(0.3f, 0.0f, 0.3f);
    void Start()
    {
        Vector3 PlayerPos = new Vector3(-3.0f, 0.0f, -4.0f);
        transform.position = PlayerPos;
        //Player.Transform = PlayerPos;
    }

    void Update()
    {
        transform.Translate(moveVelocity*Time.deltaTime);
    }
}
