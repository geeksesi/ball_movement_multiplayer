using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRandomColor : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {
        Debug.Log (Random.value);
        Color newColor = new Color (Random.value, Random.value, Random.value, 1.0f);
        // apply it on current object's material
        gameObject.GetComponent<Renderer> ().material.color = newColor;
    }

    // Update is called once per frame
    void Update () {

    }
}