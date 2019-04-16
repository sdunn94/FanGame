using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float movementSpeed;

    // Use this for initialization
    void Start()
    {
        movementSpeed = 1f;
    }

    //Update is called once per frame
    void Update()
    {
        transform.Translate(movementSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, movementSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}