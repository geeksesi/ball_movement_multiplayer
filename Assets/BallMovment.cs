using System.Collections;
using System.Collections.Generic;
using DarkRift;
using DarkRift.Client;
using UnityEngine;

public class BallMovment : MonoBehaviour {
    BallObject BallObject;

    void Awake () {
        BallObject = GetComponent<BallObject> ();
    }

    void Start () {

        Debug.Log ("Hi");
    }

    // Update is called once per frame
    void Update () {
        Vector3 mousePoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
        mousePoint.z = 0;

        BallObject.SetMovePosition (mousePoint);
        // if (Input.GetKey (KeyCode.UpArrow)) {
        //     transform.position += new Vector3(0,15,0) * Time.deltaTime;
        // }
        // else if (Input.GetKey (KeyCode.DownArrow)) {
        //     transform.position += new Vector3(0,-15,0) * Time.deltaTime;
        // }
        // else if (Input.GetKey (KeyCode.RightArrow)) {
        //     transform.position += new Vector3(15,0,0) * Time.deltaTime;
        // }
        // else if (Input.GetKey (KeyCode.LeftArrow)) {
        //     transform.position += new Vector3(-15,0,0) * Time.deltaTime;
        // }
    }
}