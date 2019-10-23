using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmaeraFollowPlayer : MonoBehaviour {
    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform Player;
    public Camera camera;
    void Start () {
        // Player = GameObject.Find("Player");
        transform.position = Player.position + new Vector3 (0, 0, -3);
        // var camera2 = getComponent<Camera>();
        camera = GetComponentInChildren<Camera> ();
        // Debug.Log(camera.GetType());
    }

    void Update () {
        if (Player) {
            Vector3 point = camera.WorldToViewportPoint (Player.position);
            Vector3 delta = Player.position - camera.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp (transform.position, destination, ref velocity, dampTime);
        }
        // transform.position = Player.position + new Vector3 (0, 0, -3);
        // transform.position 
        // transform.position = Player.position;
    }
}