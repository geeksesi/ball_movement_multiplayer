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
            transform.position += new Vector3(0,15,0) * Time.deltaTime;
        }
        else if (Input.GetKey (KeyCode.DownArrow)) {
            transform.position += new Vector3(0,-15,0) * Time.deltaTime;
        }
        else if (Input.GetKey (KeyCode.RightArrow)) {
            transform.position += new Vector3(15,0,0) * Time.deltaTime;
        }
        else if (Input.GetKey (KeyCode.LeftArrow)) {
            transform.position += new Vector3(-15,0,0) * Time.deltaTime;
        }
    }
}