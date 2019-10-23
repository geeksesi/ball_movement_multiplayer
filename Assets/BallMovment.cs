using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovment : MonoBehaviour {

    void Start () {

            Debug.Log("Hi");
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey (KeyCode.UpArrow)) {
            Debug.Log("MOVE BITCH");
            transform.position += new Vector3(0,30,0) * Time.deltaTime;
        }
        else if (Input.GetKey (KeyCode.DownArrow)) {
            Debug.Log("MOVE BITCH");
            transform.position += new Vector3(0,-30,0) * Time.deltaTime;
        }
        else if (Input.GetKey (KeyCode.RightArrow)) {
            Debug.Log("MOVE BITCH");
            transform.position += new Vector3(30,0,0) * Time.deltaTime;
        }
        else if (Input.GetKey (KeyCode.LeftArrow)) {
            Debug.Log("MOVE BITCH");
            transform.position += new Vector3(-30,0,0) * Time.deltaTime;
        }
    }
}